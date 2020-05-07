using System;

namespace Lab04
{
    public class Wheel
    {
        private string _model;
        private int _radius;
        private int _width;


        public Wheel(string model, int radius, int width)
        {
            _model = model;
            _radius = radius;
            _width = width;
        }
        
        public override string ToString()
        {
            return $"Model {_model}; R={_radius}''; W={_width}mm";
        }
    }
}