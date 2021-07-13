using System;
namespace _11.AverageSuccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            double[] numbers = { 2, 6, 4, 3, 4, 5, 6, 2, 3 };
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Average is : " + avg);

            //не успях да се сетя как да я направя с въвеждане на числата от конзолата, предполагам с вложен цикъл.
        }
    }
}
