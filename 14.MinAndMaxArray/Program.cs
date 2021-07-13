using System;

namespace MinAndMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type how many element you want to check:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Type them, after each enter:");
            int[] nums = new int[n];
            int min, max;
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            min = max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                    min = nums[i];
                if (max < nums[i])
                    max = nums[i];
            }
            Console.WriteLine("Max element is {0}, min element is {1}!", max, min);
        }
    }
}
