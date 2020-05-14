namespace Lab04.Garage
{
    public class Radio
    {
        private readonly string _make;
        private readonly bool _hasUSB;

        public Radio(string make, bool hasUsb)
        {
            _make = make;
            _hasUSB = hasUsb;
        }

        public override string ToString()
        {
            return $"Make:{_make}; Has USB: {_hasUSB}";
        }
    }
}