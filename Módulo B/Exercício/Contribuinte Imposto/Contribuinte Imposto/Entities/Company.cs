using Contribuinte_Imposto.Entities;

namespace Contribuinte_Imposto.Entities
{
    class Company : Contributor
    {
        public int NumEmployee { get; set; }

        public Company(string name, double earn, int numEmployee) : base(name, earn)
        {
            NumEmployee = numEmployee;
        }

        public override double TaxesPaid()
        {
            if (NumEmployee > 10)  
            { 
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
