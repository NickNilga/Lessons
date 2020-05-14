namespace Lab04.Garage
{
    public abstract class Vehicle
    {
        protected readonly string _make;
        protected readonly string _model;
        protected readonly Engine _engine;

        protected Vehicle(string make, string model,Engine engine)
        {
            _make = make;
            _model = model;
            _engine = engine;
        }

        public override string ToString()
        {
            return "Some Vehicle";
        }

        public void StartEngine()
        {
            _engine.Start();
        }

        public void StopEngine()
        {
            _engine.Stop();
        }

        public bool IsStarted()
        {
            return _engine.IsStarted();
        }
    }
}