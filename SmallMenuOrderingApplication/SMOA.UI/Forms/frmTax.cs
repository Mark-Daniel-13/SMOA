using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace SMOA.UI.Forms
{
    public partial class frmTax : Form
    {
        public frmTax()
        {
            InitializeComponent();
            tbTax.Text = Business.Helpers.AppSettings.GetSetting("TaxPercent");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTax.Text) || tbTax.Text == "0")
            {
                MessageBox.Show("Please Enter Valid Input!");
            }
            else { 
                Business.Helpers.AppSettings.SetSetting("TaxPercent", tbTax.Text);
                MessageBox.Show("Successfully Updated Tax Percent!");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void tbTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != '.' & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
