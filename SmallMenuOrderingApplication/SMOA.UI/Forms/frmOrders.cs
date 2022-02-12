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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            var orderList = Business.Facades.Transaction.GetAll();
            dgvOrders.DataSource = orderList.OrderByDescending(o=>o.TransactionId).ToList();
            dgvOrders.ClearSelection();
        }
        private void CellClick(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = this.dgvOrders.Rows[e.RowIndex];
                string transId = selectedRow.Cells["TransactionId"].Value.ToString();

                var detailsList = Business.Facades.Transaction.GetAllDetailsByTransactionId(Convert.ToInt32(transId));
                if (detailsList.Count > 0 && detailsList is not null) {
                    dgvOrderDetails.DataSource = Viewmodel.OrderDetailsViewModel.ToViewModel(detailsList);
                    dgvOrderDetails.ClearSelection();
                }
            }
        }

        private void dgvOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick(e);
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellClick(e);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
