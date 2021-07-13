using System;

namespace SmallSimpleNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type positive simple number: ");
            int simpleNumber = int.Parse(Console.ReadLine());
            for (int i = 2; i <= simpleNumber; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
                if (i == simpleNumber)
                    break;
            }

        }
    }
}
