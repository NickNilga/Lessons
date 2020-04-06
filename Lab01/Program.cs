//using System;

using System;

namespace Lab01
{
	internal static class Program
	{
		static void Main(string[] args)
		{
			//int k;
			
			int x = 1;
			byte y = 4;
			double d = 3.1415926;
			float f = 1.5f;
			
			int k = x + 10;
			
			Console.WriteLine();
			Console.WriteLine("x = " + x);
			
			Console.Write("x = ");
			Console.WriteLine(x);
			
			Console.Out.WriteLine();
			Console.Out.WriteLine("d = " + d);
			
			Console.Out.Write("d = ");
			Console.Out.Write(d);
			
			Console.Out.WriteLine();
			Console.Out.WriteLine();
			

			bool yesNo = 7 < 5;
			Console.Out.WriteLine("yesNo: " + yesNo);
			Console.Out.WriteLine("yesNo: " + (7>5));
			
			
			Console.Out.WriteLine();
			Console.Out.Write("Input x: ");
			string xStr = Console.In.ReadLine();

			if (int.TryParse(xStr, out x))
			{
				Console.Out.WriteLine("x^2 = " + x * x);
			}
			else
			{
				Console.Out.WriteLine("Input string was in incorrect format");
			}

		}
	}
}