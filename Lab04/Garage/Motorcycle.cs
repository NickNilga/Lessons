namespace Lab04.Garage
{
    public class Motorcycle : Vehicle
    {
        private readonly Wheel _frontWheel;
        private readonly Wheel _backWheel;

        public Motorcycle(string make, string model, Wheel frontWheel, Wheel backWheel, Engine engine)
            : base(make, model, engine)
        {
            _frontWheel = frontWheel;
            _backWheel = backWheel;
        }

        public override string ToString()
        {
            string result = $"Motorcycle: {_make} model{_model}\n" +
                            $"Engine: {_engine}\n" +
                            $"Wheels: Front: {_frontWheel} Back: {_backWheel}\n";

            return result;
        }
    }
}