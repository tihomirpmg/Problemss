using System;

namespace _6.SimpleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type positive number and see if it's simple: ");
            int simpleNumber = int.Parse(Console.ReadLine());
            if (simpleNumber == 2)
            {
                Console.WriteLine("Its simple!");
            }
            if (simpleNumber % 2 == 0)
            {
                Console.WriteLine("Its not simple!");
            }
            else
            {
                Console.WriteLine("Its simple!");
            }
            //Its not the best for this problem...
        }
    }
}
