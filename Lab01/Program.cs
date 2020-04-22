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






		// int x = 1;
		// byte y = 4;
		// double d = 3.1415926;
		// float f = 1.5f;
		//
		// int k = x + 10;
		//
		// Console.WriteLine();
		// Console.WriteLine("x = " + x);
		//
		// Console.Write("x = ");
		// Console.WriteLine(x);
		//
		// Console.Out.WriteLine();
		// Console.Out.WriteLine("d = " + d);
		//
		// Console.Out.Write("d = ");
		// Console.Out.Write(d);
		//
		// Console.Out.WriteLine();
		// Console.Out.WriteLine();
		//
		//
		// bool yesNo = 7 < 5;
		// Console.Out.WriteLine("yesNo: " + yesNo);
		// Console.Out.WriteLine("yesNo: " + (7 > 5));
		//
		//
		// Console.Out.WriteLine();
		// Console.Out.Write("Input x: ");
		// string xStr = Console.In.ReadLine();
		//
		// // Here we try to parse a string into int.
		// // If input value is not an integer, int.TryParse returns false;
		// // otherwise it converts input value of type string and stores parse value to variable marked as out 
		// if (int.TryParse(xStr, out x))
		// {
		// 	Console.Out.WriteLine("x^2 = " + x * x);
		// }
		// else
		// {
		// 	Console.Out.WriteLine("Input string was in incorrect format");
		// }

	}
}