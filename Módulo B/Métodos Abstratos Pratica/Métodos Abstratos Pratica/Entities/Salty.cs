using Métodos_Abstratos_Pratica.Entities.Enums;

namespace Métodos_Abstratos_Pratica.Entities
{
    class Salty : Totally
    {
        public double Price { get; set; }
        public int Quantity { get; set; }

        public string Filling { get; set; }

        public Salty (double price, int quantity, string filling, Type type) : base(type)
        {
            Price = price;
            Quantity = quantity;
            Filling = filling;
        }

        public override double FinalPrice()
        {
            return Price * Quantity;
        }
    }
}
