using System;

namespace NOD
{
    public class Radio
    {
        private string _make;
        private bool _hasUSB;

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