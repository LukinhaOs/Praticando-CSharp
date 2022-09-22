using Métodos_Abstratos_Pratica.Entities.Enums; 

namespace Métodos_Abstratos_Pratica.Entities
{
    class Sweets : Totally
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Cover { get; set; }

        public Sweets(double price, int quantity, string cover, Type type) : base(type)
        {
            Price = price;
            Quantity = quantity;
            Cover = cover;
        }

        public override double FinalPrice()
        {
            return Price * Quantity;
        }
    }
}
