using System;

namespace project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine($"name:{name} ");
            Console.WriteLine("Name:" + name);

            Console.WriteLine("Please enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Age :{age}");

            //bitwise operation

            int x = 8, y = 7;
            int c = x & y;
            Console.WriteLine($"Result of bitwise And operation:{c}");

             c = x | y;
            Console.WriteLine($"Result of bitwise Or operation:{c}");

            c = x ^ y;
            Console.WriteLine($"Result of bitwise XOr operation:{c}");
        }
    }
}
