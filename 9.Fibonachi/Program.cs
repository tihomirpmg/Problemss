using System;

namespace _9.Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number to show you The Fibonachi number: ");
            int n = int.Parse(Console.ReadLine());
            int f0 = 0;
            int f1 = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);
        }
    }
}
