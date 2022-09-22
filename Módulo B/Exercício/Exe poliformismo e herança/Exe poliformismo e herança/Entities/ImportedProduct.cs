using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_poliformismo_e_herança.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double fee) : base(name, price)
        {
            CustomsFee = fee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            StringBuilder priceTag = new StringBuilder();
            priceTag.Append($"Product {Name} Fee ${CustomsFee} | Total ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
            return priceTag.ToString();
        }
    }
}
