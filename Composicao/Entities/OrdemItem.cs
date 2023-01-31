using System;
using System.Collections.Generic;
using System.Globalization;

namespace Composicao.Entities
{
    internal class OrdemItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrdemItem()
        {
        }

        public OrdemItem(int quantity, double price, Product product)
        {
            this.Quantity = quantity;
            this.Price = price;
            this.Product = product;
        }

        public Double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $" +
                Price.ToString("F2",CultureInfo.InvariantCulture) +
                ", Quantity: " +
                Quantity +
                ", Subtotal: $" +
                SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}
