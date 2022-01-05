using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class ToBinary
    {
        public static void toBinary()
        {
            Console.Write("Enter number Decimal Number: ");
            int Num = Convert.ToInt32(Console.ReadLine());

            string result = " ";

            while (Num > 1)
            {
                int remainder = Num % 2;
                Num = Num / 2;
                result = Convert.ToString(remainder) + result;

            }
            result = Convert.ToString(Num) + result;
            Console.WriteLine("The Binary number : {0}", result);
        }
        static void Main(string[] args)
        {
            toBinary();
        }
    }
}
