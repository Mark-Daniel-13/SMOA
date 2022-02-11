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
                lbNameVal.Text = "";
                lbDescVal.Text = "";
                lbPriceVal.Text = "0.00";
            }
        }
    }
}
