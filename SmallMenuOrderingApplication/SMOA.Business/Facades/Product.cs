using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMOA.Business.Facades
{
    public class Product
    {
        public static Models.Product ToModel(Data.product product)
        {
            return new Models.Product()
            {
                ProductId = product.ProductId,
                Name = product.Name,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
            };
        }
        public static List<Models.Product> ToModelList(List<Data.product> products)
        {
            var productList = new List<Models.Product>();
            productList = products.Select(product => new Models.Product {
                ProductId = product.ProductId,
                Name = product.Name,
                CategoryId = product.CategoryId,
                Description = product.Description,
                Price = product.Price,
            }).ToList();

            return productList;
        }

        public static List<Models.Product> GetByCategory(int categoryId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProducts = db.Fetch<Data.product>("WHERE CategoryId = @0 AND EndDate IS NULL", categoryId);
                if (dbProducts == null) return null;

                return ToModelList(dbProducts);
            }
        }
        public static Models.Product GetByName(string name)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.product>("WHERE Name = @0 AND EndDate IS NULL", name);
                if (dbProduct == null) return null;

                return ToModel(dbProduct);
            }
        }
        public static Models.Product GetById(int productId)
        {
            using (PetaPoco.Database db = new PetaPoco.Database(Globals.DatabaseName))
            {
                var dbProduct = db.FirstOrDefault<Data.product>("WHERE ProductId = @0 AND EndDate IS NULL", productId);
                if (dbProduct == null) return null;

                return ToModel(dbProduct);
            }
        }
    }
}
