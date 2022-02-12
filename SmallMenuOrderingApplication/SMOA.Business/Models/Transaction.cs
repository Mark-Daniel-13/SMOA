using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.Business.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public double Discount { get; set; }
        public double Tax { get; set; }
        public double TotalAmount { get; set; }
    }
    public class TransactionDetails { 
        public int TransactionDetailsId { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
