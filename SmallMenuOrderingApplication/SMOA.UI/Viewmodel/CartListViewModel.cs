using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.UI.Viewmodel
{
    public class CartListViewModel
    {
        public int CartId { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public double SubTotal { get; set; }

        public static CartListViewModel ToModel(Business.Models.Product product,int cartId) {
            return new CartListViewModel {
                CartId = cartId,
                ProductName = product.Name,
                Qty = 1,
                SubTotal = product.Price,
            };
        }
    }
}
