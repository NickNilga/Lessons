namespace Lab04.Garage
{
    public class Engine
    {
        private readonly string _model;
        private readonly string _type;
        private bool _isStarted;

        public Engine(string model, string type)
        {
            _model = model;
            _type = type;
        }

        public override string ToString()
        {
            return $"Model: {_model}; type: {_type}; started: {_isStarted}";
        }

        public void Start()
        {
            _isStarted = true;
        }

        public void Stop()
        {
            _isStarted = false;
        }

        public bool IsStarted()
        {
            return _isStarted;
        }
        
        
        
    }
}