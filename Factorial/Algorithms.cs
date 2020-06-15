using System;

namespace Factorial
{
	public class Algorithms
	{
		public static int CalculateFactorial(int a)
		{
			int result = 1;
			while (a > 0)
			{
				result *= a;
				a -= 1;
			}

			return result;
		}

		public static int CalculateFactorialRecursively(int a)
		{
			return a == 0
				? 1
				: a * CalculateFactorialRecursively(a - 1);
		}
	}
}