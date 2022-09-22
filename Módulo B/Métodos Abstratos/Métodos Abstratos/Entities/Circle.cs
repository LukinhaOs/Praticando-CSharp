using Métodos_Abstratos.Entities.Enums;
using System;

namespace Métodos_Abstratos.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius, Colors color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; 
        }
    }
}
