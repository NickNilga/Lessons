using System;


namespace Fibonachi
{
    class Program
    {
        static void Main()
        {
            int a = Number();
            int b = Number();
            
            Console.Out.WriteLine("Nod of {0} and{1}={2}",a,b, FindNOD(b, a));
            Console.Out.WriteLine("Nod R ={0}", FindNodR(b, a));
        }

        private static int Number()
        {
            int num;
            Console.Out.Write("Enter number or elements:");
            string strNumber = Console.In.ReadLine();
            int.TryParse(strNumber, out num);
            return num;
        }
       


        private static int FindNOD(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else b -= a;
            }

            return a;
        }

        private static int FindNodR(int a, int b)
        {
            return (a%b == 0) ? b : FindNodR(b, a%b);
        }

    }
}