using Métodos_Abstratos_Pratica.Entities.Enums;

namespace Métodos_Abstratos_Pratica.Entities
{
    abstract class Totally
    {
        public Type Food { get; set; }

        public Totally (Type food)
        {
            Food = food;
        }

        public abstract double FinalPrice();
    }
}
