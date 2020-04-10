using System;

namespace Lab03
{
	// Arrays
	internal static class Program
	{
		private static void Main()
		{
			int[] arrayB = new int[10];

			arrayB[0] = 45;
			arrayB[1] = 53;
			arrayB[2] = 25;
			arrayB[3] = 41;
			arrayB[4] = -8;
			arrayB[5] = 87;
			arrayB[6] = 4;
			arrayB[7] = -5;
			arrayB[8] = 465;
			arrayB[9] = 32;
			
			int[] arrayA = new[] {1, 2, 3, 4, 5, 6};

			int[] arrayC = {1, 2, 3, 4, 5, 6};


			for (int i = 0; i < arrayA.Length; i++)
			{
				Console.Out.WriteLine("array [{0}] = {1}", i, arrayA[i]);
			}

			foreach (int b in arrayB)
			{
				Console.Out.WriteLine("b = {0}", b);
			}
		}
	}
}