using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.UI.Viewmodel
{
    public class OrderDetailsViewModel
    {
        public int ProductId{ get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }

        public static List<OrderDetailsViewModel> ToViewModel(List<Business.Models.TransactionDetails> transactionDetails) {
            var detailsViewModel = new List<OrderDetailsViewModel>();
            detailsViewModel = transactionDetails.Select(detail => new OrderDetailsViewModel{
               ProductId = detail.ProductId,
               ProductName = Business.Facades.Product.GetById(detail.ProductId).Name,
               Qty = detail.Quantity,
           }).ToList();

            return detailsViewModel;
        }
    }
}
