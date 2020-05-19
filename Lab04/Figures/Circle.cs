using System;

namespace Lab04.Figures
{
    public class Circle : Figure
    {
        private readonly float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return $"Circle radius: {_radius}";
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}