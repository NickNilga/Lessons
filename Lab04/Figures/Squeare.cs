using System;

namespace Lab04.Figures
{
    public class Square:Figure
    {
        private readonly float _side;

        public Square(float side)
        {
            _side = side;
        }
        
        public override string ToString()
        {
            return $"Square: {_side}x{_side}";
        }

        public override double GetArea()
        {
            return Math.Pow(_side, 2);
        }
    }
    
}