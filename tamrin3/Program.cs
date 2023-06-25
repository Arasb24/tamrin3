using System;
using System.Runtime.InteropServices;

namespace test
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Calc(x, y);
        }
        private static void Calc(int x, int y)
        {
            double Result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));
            Console.WriteLine("Reasult: " + Result);

        }

    }
}