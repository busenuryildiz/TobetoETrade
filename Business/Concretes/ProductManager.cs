using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Ürün eklendi");
        }
    }
}
