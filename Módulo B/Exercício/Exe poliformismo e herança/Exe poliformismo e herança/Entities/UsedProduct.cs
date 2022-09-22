using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_poliformismo_e_herança.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {

        }
        public UsedProduct(string name, double price, DateTime manufacture) : base(name, price)
        {
            ManufactureDate = manufacture;
        }

        public override string PriceTag()
        {
            StringBuilder priceTag = new StringBuilder();
            priceTag.Append($"Product: {Name} 'Used' | ${Price.ToString("F2", CultureInfo.InvariantCulture)} | (Manufacture: {ManufactureDate.ToString("dd/MM/yyyy")})");
            return priceTag.ToString();
        }
    }
}
