using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMOA.UI.Forms
{
    public partial class frmMenu : Form
    {
        private List<Business.Models.Product> loadedProductList;
        private Business.Models.Product SelectedProduct;
        private Viewmodel.CartListViewModel selectedItemOnCart;
        private List<Viewmodel.CartListViewModel> CartList = new();

        private double discount = 0.00;
        private double tax = 0.00;
        private double subtotal = 0.00;
        private double total = 0.00;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnLO_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Open Login Form
            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "frmLogin"))
            {
                var frmLogin = (frmLogin)Application.OpenForms["frmLogin"];
                frmLogin.clearFields();
                frmLogin.Show();
            }
        }
        private System.Windows.Forms.Button AddItem(string btnName,int btnY,int categoryType) {
            Button btn = new Button();
            ItemsPnl.Controls.Add(btn);
            
            btn.Top = btnY * 100;
            btn.Left = 60;
            btn.Width = 515;
            btn.Height = 67;
            btn.Text = btnName;
            btn.FlatStyle = FlatStyle.Popup;
            btn.Click += new EventHandler(BtnClick);
            return btn;
        }
        void BtnClick(object sender, EventArgs e) {
            var itemName = ((Button)sender).Text;
            var productModel = loadedProductList.Where(p => p.Name == itemName).FirstOrDefault();

            SelectedProduct = productModel;
            lbNameVal.Text = productModel is not null ? productModel.Name : "";
            lbDescVal.Text = productModel is not null ? productModel.Description : "";
            lbPriceVal.Text = productModel is not null ? productModel.Price.ToString("N2") : "0.00";
        }
        private void btnBurger_Click(object sender, EventArgs e)
        {
            ItemsPnl.Controls.Clear();
            CreateButton(1);
        }

        private void btnBev_Click(object sender, EventArgs e)
        {
            ItemsPnl.Controls.Clear();
            CreateButton(2);
        }

        private void btnCm_Click(object sender, EventArgs e)
        {
            ItemsPnl.Controls.Clear();
            CreateButton(3);
        }
        private void CreateButton(int categoryType) {
            var allBurgers = Business.Facades.Product.GetByCategory(categoryType);
            if (allBurgers is not null && allBurgers.Count > 0)
            {
                for (int x = 1; x <= allBurgers.Count(); x++)
                {
                    AddItem(allBurgers[x - 1].Name, x, categoryType);
                };

                loadedProductList = allBurgers;
                SelectedProduct = null;
                lbNameVal.Text = "";
                lbDescVal.Text = "";
                lbPriceVal.Text = "0.00";
            }
        }

        private void ComputeSubTotal() {
            if (CartList is not null && CartList.Count > 0)
            {
                var _subtotal = CartList.Sum(s => s.SubTotal);
                subtotal = _subtotal;
                lbSubTotalVal.Text = _subtotal.ToString("N2");
            }
            else {
                subtotal = 0;
                lbSubTotalVal.Text = "0.00";
            }
        }
        private void ComputeTotal() {
            if (CartList is not null && CartList.Count > 0) {

                var discountedTotal = subtotal - discount;
                total = (discountedTotal + tax);
                lbTotalVal.Text = total.ToString("N2");
            }
        }
        private void ComputeDiscount() {
            if (CartList is not null && CartList.Count > 0) {
                var total = Convert.ToDouble(lbSubTotalVal.Text);
                //assuming it's a one time coupon only
                discount = total * 0.1;
                lbDiscountVal.Text = discount.ToString("N2");
            }
        }
        private void ComputeTax() {
            if (CartList is not null && CartList.Count>0)
            {
                var total = Convert.ToDouble(lbSubTotalVal.Text);
                var _tax = Convert.ToDouble(Business.Helpers.AppSettings.GetSetting("TaxPercent"));
                tax = total * (_tax/100); // tax is the whole number tax value
                lbTaxVal.Text = tax.ToString("N2");
            }
        }
        private void btnATC_Click(object sender, EventArgs e)
        {
            if (SelectedProduct is not null) {
                CartList.Add(Viewmodel.CartListViewModel.ToModel(SelectedProduct,CartList.Count+1));
            }

            GroupList();
            
        }
        private List<Viewmodel.CartListViewModel> SumQtySubTotal() { 
            return CartList.GroupBy(c => c.ProductName)
                                            .Select(cl => new Viewmodel.CartListViewModel
                                            {
                                                ProductName = cl.First().ProductName,
                                                Qty = cl.Sum(q => q.Qty),
                                                SubTotal = cl.Sum(s => s.SubTotal),
                                            }).ToList();
        }
        private void GroupList() {
            var groupedList = SumQtySubTotal();

            cartListDGV.DataSource = groupedList;
            cartListDGV.ClearSelection();
            ComputeSubTotal();
            if (discount > 0)
            {
                ComputeDiscount();
            }
            ComputeTax();
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedItemOnCart is not null)
            {
                CartList = CartList.Where(c => c.CartId != selectedItemOnCart?.CartId).ToList();
                GroupList();

                if (CartList.Where(c => c.ProductName == selectedItemOnCart.ProductName).Count() == 0)
                {
                    selectedItemOnCart = null;
                }
                btnRemove.Enabled = false;
            }
        }
        private void CellClick(DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0)
            {
                btnRemove.Enabled = true;
                var selectedRow = this.cartListDGV.Rows[e.RowIndex];
                string _productName = selectedRow.Cells["ProductName"].Value.ToString();
                selectedItemOnCart = CartList.Where(c => c.ProductName == _productName).FirstOrDefault();
            }
        }
        private void cartListDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick(e);
        }

        private void cartListDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick(e);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnBurger.PerformClick();
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            if (tbCouponCode.Text == "GODISC10") {
                ComputeDiscount();
                MessageBox.Show("Coupon Successfully Applied!");
                tbCouponCode.Clear();
            }
            else {
                MessageBox.Show("Invalid Coupon Code!");
                tbCouponCode.Clear();
            }
        }

        private void lbSubTotalVal_TextChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void lbDiscountVal_TextChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void lbTaxVal_TextChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            using (var frmTax = new frmTax()) {
                if (frmTax.ShowDialog() == DialogResult.OK)
                {
                    ComputeTax();
                }
            }
        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            using (var frmCheckOut = new frmCheckOut()) {
                if (frmCheckOut.ShowDialog() == DialogResult.OK) {
                    var transactionModel = new Business.Models.Transaction() {
                        Tax = tax,
                        Discount = discount,
                        TotalAmount = total,
                    };
                    var cartItems = SumQtySubTotal();

                    var transactionDetailModel = new List<Business.Models.TransactionDetails>();
                    transactionDetailModel = cartItems.Select(item => new Business.Models.TransactionDetails() { 
                        ProductId = (int)Business.Facades.Product.GetByName(item.ProductName)?.ProductId,
                        Quantity = item.Qty,
                    }).ToList();

                    var queryTransaction = Business.Facades.Transaction.AddTransaction(transactionModel, transactionDetailModel);
                    if (queryTransaction)
                    {
                        ClearMenu();
                        MessageBox.Show("Order Successfully Made!");
                    }
                    else {
                        MessageBox.Show("Order Failed, Please To Check Out Again!");
                    }
                }
            }
        }
        private void ClearMenu()
        {
            loadedProductList.Clear();
            SelectedProduct = null;
            CartList.Clear();
            selectedItemOnCart = null;

            discount = 0.00;
            lbDiscountVal.Text = discount.ToString("N2");
            tax = 0.00;
            lbTaxVal.Text = tax.ToString("N2");
            subtotal = 0.00;
            lbSubTotalVal.Text = subtotal.ToString("N2");
            total = 0.00;
            lbTotalVal.Text = subtotal.ToString("N2");
            cartListDGV.DataSource = null;
            cartListDGV.Refresh();
            btnBurger.PerformClick();
        }
    }
}
