using System;

namespace Lab04
{
    public class Engine
    {
        private string _model;
        private string _type;
        
        public Engine(string model, string type)
        {
            _model = model;
            _type = type;
            
        }

        public override string ToString()
        {
            return $"Model {_model}; type{_type}";
        }
        
    }
}