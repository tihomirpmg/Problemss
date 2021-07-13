using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type what you want to calculate and type two numbers: ");
            Console.WriteLine("addition, substract, multiplication, divide");
            string action;
            do
            {
                action = Console.ReadLine();
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = 0;
                switch (action)
                {
                    case "addition":
                        result = n1 + n2;
                        Console.WriteLine(result);
                        break;
                    case "substract":
                        result = n1 - n2;
                        Console.WriteLine(result);
                        break;
                    case "multiplication":
                        result = n1 * n2;
                        Console.WriteLine(result);
                        break;
                    case "divide":
                        result = n1 / n2;
                        Console.WriteLine(result);
                        break;
                }
            }
            while (action != "end");
            Console.WriteLine("End");
        }
    }
}
