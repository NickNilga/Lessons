using System;

namespace Lab03
{
	// Arrays
	internal static class Program
	{
		private static void Main()
		{
			int[] a = LoadArray();
			int[] result = FindMax(a);
			double avg = FindAvg(a);
			Console.Out.WriteLine("Max = {0}; max index = {1}; Avg = {2}", result[0], result[1], avg);
		}

		private static int[] LoadArray()
		{
			int numberOfElements;

			Console.Out.Write("Enter the number or elements:");
			string strNumber = Console.In.ReadLine();
			int.TryParse(strNumber, out numberOfElements);

			int[] a = new int[numberOfElements];

			for (int i = 0; i < a.Length; i++)
			{
				Console.Out.Write("Enter {0} value: ", i + 1);
				string str = Console.In.ReadLine() ?? "0";
				a[i] = int.Parse(str);
			}

			Console.Out.Write("Array: [");
			for (int i = 0; i < a.Length; i++)
			{
				if (i < a.Length - 1)
				{
					Console.Out.Write("{0}, ", a[i]);
				}
				else
				{
					Console.Out.Write("{0}", a[i]);
				}
			}

			Console.Out.WriteLine("]");

			Console.Out.WriteLine($"Array: [{string.Join(", ", a)}]");

			return a;
		}


		private static int[] FindMax(int[] array)
		{
			int max = array[0];
			int maxIndex = 0;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] > max)
				{
					max = array[i];
					maxIndex = i;
				}
			}

			int[] result = {max, maxIndex};

			return result;
		}

		private static double FindAvg(int[] array)
		{
			double sum = 0;
			for (int i = 0; i < array.Length; i++)
			{
				sum += array[i];
			}

			return sum / array.Length;
		}
	}
}