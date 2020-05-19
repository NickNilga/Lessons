using System;
using Lab04.Garage;

namespace Lab04
{
    public static class LabCars
    {
        public static void Execute()
        {
            Engine hybridEngine = new Engine("BMW", "Hybrid");
            Vehicle bmwCar = new Car("X5", "BMW", hybridEngine, "Nokian", 15, 185);

            Wheel frontWheel = new Wheel("GoodYear", 20, 100);
            Wheel backWheel = new Wheel("GoodYear", 20, 120);
            Engine motoEngine = new Engine("Honda", "Sport");
            Vehicle motorcycle = new Motorcycle("Honda", "Racer", frontWheel, backWheel, motoEngine);


            bool exit = false;

            do
            {
                Console.Clear();
                Console.Out.WriteLine(bmwCar);
                Console.Out.WriteLine();
                Console.Out.WriteLine(motorcycle);

                char key = PrintMenu();

                switch (key)
                {
                    case '4':
                        exit = true;
                        break;
                    case '1' when bmwCar.IsStarted():
                        bmwCar.StopEngine();
                        break;
                    case '1':
                        bmwCar.StartEngine();
                        break;
                    // case '2':
                    // {
                    //     Radio pioneerRadio = new Radio("Pioneer", true); 
                    //     bmwCar.SetRadio(pioneerRadio);
                    //     break;
                    // }
                    // case '3':
                    //     bmwCar.RemoveRadio();
                    //     break;
                }
            } while (!exit);
        }

        private static char PrintMenu()
        {
            Console.Out.WriteLine("1. Start / Stop engine");
            Console.Out.WriteLine("2. Install radio");
            Console.Out.WriteLine("3. Remove radio");
            Console.Out.WriteLine("4. Exit");
            Console.Out.Write("Select Action: ");
            int key = Console.In.Read();
            return Convert.ToChar(key);
        }
    }
}