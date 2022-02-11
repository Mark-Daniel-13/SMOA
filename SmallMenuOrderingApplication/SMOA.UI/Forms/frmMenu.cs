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
            lbPriceVal.Text = productModel is not null ? productModel.Price.ToString("N0") : "0.00";
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

        private void ComputeTotal() {
            if (CartList is not null)
            {
                var subtotal = CartList.Sum(s => s.SubTotal);
                lbTotalVal.Text = subtotal.ToString("N0");
            }
            else {
                lbTotalVal.Text = "0.00";
            }
        }
        private void btnATC_Click(object sender, EventArgs e)
        {
            if (SelectedProduct is not null) {
                CartList.Add(Viewmodel.CartListViewModel.ToModel(SelectedProduct,CartList.Count+1));
            }

            GroupList();
        }
        private void GroupList() {
            var groupedList = CartList.GroupBy(c => c.ProductName)
                                            .Select(cl => new Viewmodel.CartListViewModel
                                            {
                                                ProductName = cl.First().ProductName,
                                                Qty = cl.Sum(q => q.Qty),
                                                SubTotal = cl.Sum(s => s.SubTotal),
                                            }).ToList();

            cartListDGV.DataSource = groupedList;
            cartListDGV.ClearSelection();
            ComputeTotal();
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
                var total = Convert.ToDouble(lbTotalVal.Text);
                discount = total* 0.1;
                var _total = total - discount;
                MessageBox.Show("Coupon Successfully Applied!");
                tbCouponCode.Clear();
                lbTotalVal.Text = _total.ToString("N0");
            }
            else {
                MessageBox.Show("Invalid Coupon Code!");
                tbCouponCode.Clear();
            }
        }
    }
}
