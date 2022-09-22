

namespace Contribuinte_Imposto.Entities
{
    abstract class Contributor
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contributor()
        {

        }

        protected Contributor(string name, double earn)
        {
            Name = name;
            AnualIncome = earn;
        }

        public abstract double TaxesPaid();
    }
}
