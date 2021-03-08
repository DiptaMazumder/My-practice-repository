using System;
using System.Numerics;

namespace facebook_classes
{
    class yourprofile
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter two integer numbers:");
               string s1 = Console.ReadLine();
               string s2 = Console.ReadLine();
                BigInteger x = BigInteger.Parse(s1);
                BigInteger y = BigInteger.Parse(s2);
                Console.WriteLine($"After substraction result is:{ BigInteger.Subtract(x, y)}");
                
            }
        }
    }
}
