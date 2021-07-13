using System;

namespace _1.Discriminant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type three numbers to calculate the discriminant: ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double discriminant = ((b * b) - (4 * a * c));
            Console.WriteLine($"The discriminant is: {discriminant}");
        }
    }
}
