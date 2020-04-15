using System;

namespace Lab03
{
	// Arrays
	internal static class Program
	{
		private static void Main()
		{
			int numberOfElements;
			
			
			Console.Out.Write("Enter the number or elements:");
			string strNumber = Console.In.ReadLine();
			int.TryParse(strNumber, out numberOfElements);
			
			int[] a = new int[numberOfElements];
			
			for (int i = 0; i < a.Length; i++)
			{
				Console.Out.Write("Enter {0} value: ", i + 1);
				string str = Console.In.ReadLine();
				a[i] = int.Parse(str);
			}
			
			// for (int i = 0; i < a.Length; i ++)
			// {
			// 	Console.Out.WriteLine("x[{0}] = {1} ", i+1, a[i]);
			// }

			int max = a[0];
			for (int i = 1; i < a.Length; i ++)
			{
				if (a[i] > max)
				{
					max = a[i];
				}
			}
			Console.Out.WriteLine(max);
			
		}
	}
}