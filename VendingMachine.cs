using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Vendingachine
    {
		static int cash;
		static int total = 0;
		static int i = 0;

		public static int calculate(int cash, int[] notes)
		{

			int remindar;
			if (cash == 0)
			{
				return 0;
			}
			else
			{
				if (cash >= notes[i])
				{

					int noteCount = cash / notes[i];
					remindar = cash % notes[i];
					cash = remindar;
					total += noteCount;
					Console.WriteLine(notes[i] + "Notes :: " + noteCount);
				}
				i++;
				return calculate(cash, notes);
			}
		}
		Public static void Main()
		{
			Console.WriteLine("Enter Amount:");
			int cash = int.Parse(Console.ReadLine());
			int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

			Vendingachine.calculate(cash, notes);
			Console.WriteLine("Total Number of Notes are :" + Vendingachine.total);
			Console.ReadKey();
		}
	}
}
