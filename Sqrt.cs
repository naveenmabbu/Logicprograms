using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Sqrt
    {
        public static void sqrt(int c)
        {
            int t = c;
            long epsilon = (long)10E-15;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine(t);
        }
        static void Main(string[] args)
        {
            sqrt(16);
        }
    }
}
