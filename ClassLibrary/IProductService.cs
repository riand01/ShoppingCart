using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface IProductService
    {
        bool DoesProductExist(int productIdToFind);

        public void AddToList(Product p, int antal);

        
    }
}
