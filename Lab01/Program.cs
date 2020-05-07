//using System;

using System;

namespace Lab01
{
	internal static class BubbleSorting
	{
		private static void Main()
		{
			int[] a = LoadArray();
			PrintArray(a);
			
			int[] sort = SortArray(a);
			PrintArray(sort);

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
				string str = Console.In.ReadLine();
				a[i] = int.Parse(str);
			}
			
			
			return a;
		}

		private static void PrintArray(int[] a)
		{
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
		}

		private static int[] SortArray(int[] a)
		{
			bool flag;

			do
			{
				flag = false;

				for (int i = 0; i < a.Length - 1; i++)
				{
					if (a[i] > a[i + 1])
					{
						int swap = a[i];
						a[i] = a[i + 1];
						a[i + 1] = swap;

						flag = true;
					}


				}
			} while (flag);
			
			return a;
		}

	}
}