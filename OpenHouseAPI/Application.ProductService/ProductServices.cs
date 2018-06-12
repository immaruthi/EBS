using Application.Common.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ProductService
{
    public class ProductServices
    {
        public static List<ProductModelData> GetAllProducts()
        {
            var getAllProductsResponse = new List<ProductModelData>();

            var itemModelData = new List<ItemModelData>();

            itemModelData.Add(new ItemModelData()
            {
                ItemDescription = "Aviva Herbal Products",
                ItemPrice = 12.34,
                ItemType = ItemMaster.B4102151
            });

            itemModelData.Add(new ItemModelData()
            {
                ItemDescription = "Pact Herbal Products",
                ItemPrice = 10.34,
                ItemType = ItemMaster.B4102151
            });

            getAllProductsResponse.Add(new ProductModelData()
            {
                ProductItems = itemModelData,
                ProductType = ProductMaster.Herbal
            });

            return getAllProductsResponse;
        }
    }
}
