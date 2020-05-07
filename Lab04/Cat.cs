using System;

namespace Lab04
{
    public class Cat
    {
        private string _name;
        private string _color;
        
        
        public Cat(string name, string color)
        {
            _name = name;
            _color = color;
        }

        public void SayName()
        {
            Console.Out.WriteLine("My name {0}", _name);
        }
        public void SayColor()
        {
            Console.Out.WriteLine("My name {0}", _color);
        }
    }
}