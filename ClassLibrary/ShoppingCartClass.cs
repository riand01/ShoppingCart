using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ShoppingCartClass
    {
        public void AddProduct()
        {
            IProductService productService = new ProductService();
            Product product = new();
            //id = product.Id;
            //count = product.Count;
           // productService.DoesProductExist();
            //productService.AddToList();
            

        }

        public decimal CalculateSum(List<Product> list)
        {

            decimal totalPrice = 0;
            foreach (var item in list)
            {
                totalPrice = item.Price * item.Count;

            }
            return totalPrice;
        }
    }
}
