using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_poliformismo_e_herança.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder priceTag = new StringBuilder();
            priceTag.Append($"Product: {Name} | ${Price.ToString("F2", CultureInfo.InvariantCulture)} ");
            return priceTag.ToString();
        }
    }
}
