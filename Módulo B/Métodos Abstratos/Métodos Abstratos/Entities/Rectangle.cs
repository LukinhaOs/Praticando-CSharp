using Métodos_Abstratos.Entities.Enums;

namespace Métodos_Abstratos.Entities
{
    class Rectangle : Shape
    {

        public double Widht { get; set; }
        public double Height { get; set; }

        public Rectangle(double widht, double height, Colors color) : base(color)
        {
            Widht = widht;
            Height = height;
        }
        public override double Area()
        {
            return Widht * Height;
        }
    }
}
