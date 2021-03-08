using System;
using System.Numerics;

namespace project12
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter two large number:");
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                BigInteger x = BigInteger.Parse(s1);
                BigInteger y = BigInteger.Parse(s2);
                Console.WriteLine($"After multipling we get:{BigInteger.Multiply(x, y)}");
            }
        }
    }
}
