using Métodos_Abstratos.Entities.Enums;

namespace Métodos_Abstratos.Entities
{
    abstract class Shape
    {
        public Colors Color { get; set; }

        public Shape(Colors color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
