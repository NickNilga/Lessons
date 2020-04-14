using System;

namespace Lab03
{
	// Arrays
	internal static class Program
	{
		private static void Main()
		{
			int[] a = new int[10];

			a[0] =  1;
			a[1] =  2;
			a[2] =  12;
			a[3] =  18;
			a[4] =  20;
			a[5] =  25;
			a[6] =  0;
			a[7] =  -11;
			a[8] =  97;
			a[9] =  107;

			for (int i = 0; i < a.Length; i ++)
			{
				Console.Out.WriteLine("x[{0}] = {1} ", i, a[i] );
			}
		}
	}
}