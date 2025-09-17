using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraApi.Domain.Model
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        private int Quantity { get; set; }

        public Product(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public void AlteraQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }

}
