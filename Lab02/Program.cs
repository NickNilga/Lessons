using System;

namespace Lab02
{
	internal static class Program
	{
		private static void Main()
		{
			Console.Out.WriteLine("Calculation of the roots of the quadratic equation");
			Console.Out.WriteLine();

			double a = InputCoefficient("a");
			double b = InputCoefficient("b");
			double c = InputCoefficient("c");

			double d = CalculateDiscriminant(a, b, c);

			CalculateRoots(a, b, c, d);


		}

		private static double InputCoefficient(string coefficientName)
		{
			Console.Out.Write("Input {0} and press Enter: ", coefficientName);
			string strValue = Console.In.ReadLine();
			double value;
			
			if (double.TryParse(strValue, out value))
			{
				return value;
			}
			
			Console.Out.WriteLine("Input string was in incorrect format");
			return 0;
		}

		private static double CalculateDiscriminant(double a, double b, double c)
		{
			double d = Math.Pow(b, 2) - 4 * a * c;
			
			Console.Out.WriteLine("D = {0:F2}", d);

			return d;
		}

		private static void CalculateRoots(double a, double b, double c, double d)
		{
				double x1 = ((-b + Math.Sqrt(d)) / (2 * a));
				double x2 = ((-b - Math.Sqrt(d)) / (2 * a));
				Console.Out.WriteLine("x1 = {0:F1}; x2={1:F1}", x1, x2);
		}
	}
}