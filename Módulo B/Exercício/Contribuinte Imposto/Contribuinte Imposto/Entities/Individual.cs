using Contribuinte_Imposto.Entities;

namespace Contribuinte_Imposto.Entities
{
    class Individual : Contributor
    {
        public double HealthySpend { get; set; }

        public Individual()
        {

        }
        public Individual(string name, double earn, double healthyspend) : base(name, earn)
        {
            HealthySpend = healthyspend;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome < 20000.0)
            {
                return (AnualIncome * 0.15) - (HealthySpend * 0.5);
            }
            else
            {
                return (AnualIncome * 0.25) - (HealthySpend * 0.5);
            }
        }
    }
}
