using System;

namespace FractionalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type fractional number and how many numbers you want after the comma: ");
            float fractionalNumber = float.Parse(Console.ReadLine());
            int afterComma = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(fractionalNumber, afterComma));
        }
    }
}
