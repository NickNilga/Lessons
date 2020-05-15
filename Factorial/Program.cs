using System;

namespace Factorial
{
	internal static class Program
	{
		static void Main()
		{
			int x = GetX();
			Console.Out.WriteLine("{0}! = {1}", x, CalculateFactorial(x));
			Console.Out.WriteLine("{0}! = {1}", x, CalculateFactorialRecursively(x));
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
			while (a > 0)
			{
				result *= a;
				a -= 1;
			}

			return result;
		}

		private static int CalculateFactorialRecursively(int a)
		{
			return a == 0
				? 1
				: a * CalculateFactorialRecursively(a - 1);
		}
	}
}