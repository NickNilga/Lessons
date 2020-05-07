

using System;
using NOD;

namespace Lab04
{
    class Program
    {
        static void Main()
        {
            Engine hybridEngine = new Engine("BMW", "Hybrid");
            
            Car bmwCar = new Car("X5", "BMW", hybridEngine, "Nokian",15, 185);
            
            Console.Out.WriteLine(bmwCar);
            Console.Out.WriteLine();
            
            Radio radio = new Radio("Pioneer",true);
            bmwCar.SetRadio(radio);
            
            Console.Out.WriteLine(bmwCar);
            Console.Out.WriteLine();

            bmwCar.RemoveRadio();
            Console.Out.WriteLine(bmwCar);
            Console.Out.WriteLine();
        }
    }
}