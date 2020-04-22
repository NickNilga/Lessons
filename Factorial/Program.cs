using System;
using System.Transactions;

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            int x = GetX();
            Console.Out.WriteLine("Factoial:{0}", CalculateFactorial(x));
            Console.Out.WriteLine("Factoial:{0}", CalculateFactorial2(x));
        }

        private static int GetX()
        {
            int factorial;
            
            Console.Out.Write("Enter Factorial:");
            string strNumber = Console.In.ReadLine();
            int.TryParse(strNumber, out factorial);
            
            return factorial;
        }

        private static int CalculateFactorial(int a)
        {
            int result = 1;
            while(a > 0)
            {
                result *= a;
                a -= 1;
            }

            return result;
        }

        private static int CalculateFactorial2(int a)
        {
            return a == 0 
                ? 1 
                : a * CalculateFactorial2(a - 1);
        }
    }
}


    
    