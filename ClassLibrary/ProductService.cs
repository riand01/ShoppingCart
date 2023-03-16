using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public bool DoesProductExist(int productIdToFind)
        {
            Product product = Products.FirstOrDefault(p => p.Id == productIdToFind);
            if (product==null) return false;
            return true;
        }
        public void AddToList(Product p, int antal)
        {
            
            
            if (DoesProductExist(p.Id) == false)
            {
                Products.Add(p);
                p.Count = antal;
            }
            else
            {
                p.Count = antal + p.Count;
            }
            
        }
  
    }
}
