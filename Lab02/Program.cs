using System;
using System.ComponentModel.Design;

namespace Lab02
{
    internal static class Program
    {
        private static void Main()
        {
            Console.Out.WriteLine("Calculation of the roots of the quadratic equation");
            Console.Out.WriteLine();

            double a;
            double b;
            double c;

            // Define variables for keeping a, b, and c - coefficients of equation.
            // Note that they can be with double parts, so int is not a suitable type.


            // Ask the user to enter a by printing invitation to the console

            Console.Out.Write("Input a and press Enter: ");
            string strA = Console.In.ReadLine();
            if (double.TryParse(strA, out a))
            {
                Console.Out.WriteLine();
            }
            else
            {
                Console.Out.WriteLine("Input string was in incorrect format");
            }

            Console.Out.Write("Input b and press Enter: ");
            string strB = Console.In.ReadLine();
            if (double.TryParse(strB, out b))
            {
                Console.Out.WriteLine();
            }
            else
            {
                Console.Out.WriteLine("Input string was in incorrect format");
            }

            Console.Out.Write("Input c and press Enter: ");
            string strC = Console.In.ReadLine();
            if (double.TryParse(strC, out c))
            {
                Console.Out.WriteLine();
            }
            else
            {
                Console.Out.WriteLine("Input string was in incorrect format");
            }

            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.Out.WriteLine("D = " + d);

            
            if (d > 0)
            {
                double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
            
                Console.Out.WriteLine("x1= " + x1); 
                Console.Out.WriteLine("x2= " + x2);
            }
            else if (d == 0)
            {
                double x1 = -b;
                Console.Out.WriteLine("x1= " + x1); 
            }
            else
            {
                Console.Out.WriteLine("no roots");   
            }



            
                                      

            // Read string value entered by the user.
            // <type> strA = Console.In.ReadLine();


            // Do the same for b and c


            // Define a variable for keeping discriminant and calculate it' value.

            // Output discriminant value to the console like this: "d = 3242"

            // Analyze discriminant. Put if...else block like this
            // if (d>0)
            // {
            //   calculate roots
            // }
            // else if (d == 0)
            // {
            // calculate root
            // }
            // else
            // {
            //   write a message that there are no roots.
            // }
            //
        }
    }
}