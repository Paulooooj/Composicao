using System;
using System.Collections.Generic;

namespace Composicao.Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
