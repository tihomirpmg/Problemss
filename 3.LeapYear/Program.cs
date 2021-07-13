using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an year and see if it is leap year:");
            int leapYear = int.Parse(Console.ReadLine());
            if (leapYear % 4 == 0)
            {
                Console.WriteLine("It is a leap year.");
            }
            else
            {
                Console.WriteLine("It is not a leap year.");
            }
        }
    }
}
