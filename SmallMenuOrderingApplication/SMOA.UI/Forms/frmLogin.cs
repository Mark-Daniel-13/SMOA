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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Form Field Properties
        private string fUsername
        {
            get { return tbUsername.Text; }
            set { tbUsername.Text = value; }
        }
        private string fPassword
        {
            get { return tbPass.Text; }
            set { tbPass.Text = value; }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = Business.Facades.User.GetByUsernamePassword(fUsername,fPassword);
            if (user is not null)
            {
                this.Hide();
                var frmMenu = new Forms.frmMenu();
                //frmAdmin.Closed += (s, args) => this.Close();
                frmMenu.Show();
            }
            else {
                MessageBox.Show("Username or password is invalid");
            }
        }
    }
}
