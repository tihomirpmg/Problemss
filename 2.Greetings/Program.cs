using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type student name and course name:");
            string studentName = Console.ReadLine();
            string courseName = Console.ReadLine();
            string message = string.Format("Hello {0} you are welcome in {1}!", studentName, courseName);
            Console.WriteLine(message);
        }
    }
}
