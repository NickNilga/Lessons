namespace Lab04.Figures
{
    public class Rectangle:Figure
    {
        private readonly float _height;
        private readonly float _width;

        public Rectangle(float height, float width)
        {
            _height = height;
            _width = width;
        }
        public override string ToString()
        {
            return $"Rectangle: {_height}x{_width}";
        }

        public override double GetArea()
        {
            return _height * _width;
        }
    }
}