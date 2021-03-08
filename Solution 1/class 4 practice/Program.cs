using System;

namespace class_4_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Dipta";
            Console.WriteLine(s.Length);
            string[] s1 = new string[] {"Dipta","Miraj","Druba" };
            Console.WriteLine(s1.Length);

            int[] a = new int[] { 2, 4, 3, 1, 5 };
            Console.WriteLine(a.Length);

            float f = 3.56787897756564546644546645646466464646f;
            Console.WriteLine(f);
            double d = 3.56787897756564546644546645646466464646;
            Console.WriteLine(d);
            decimal m = 3.56787897756564546644546645646466464646m;
            Console.WriteLine(m);

            //bitwise operation
            //And 
            int a1 = 7, b1 = 6;
            int c1 = a1 & b1;
            Console.WriteLine($"after And operation:{c1}");

            a1 = 0b_111;
            b1=0b_110;
            c1 = a1 & b1;
            Console.WriteLine($"after And operation:{c1}");
            //but i want to print the result in binary
            Console.WriteLine($"After And operation:{Convert.ToString(c1, toBase: 2)}");

            //Or
            a1 = 0b_1101;
            b1 = 0b_111;
            c1 = a1 | b1;
            Console.WriteLine($"after Or operation:{c1}");

            a1 = 13;
            b1 = 7;
            c1 = a1 | b1;
            Console.WriteLine($"after Or operation:{c1}");
            Console.WriteLine($"After Or operation:{Convert.ToString(c1, toBase: 2)}");

            //toggle
            a1 = 16;
            b1 = ~a1;
            Console.WriteLine($"toggle of 16 is:{b1}");

            a1 = 0b_00010<<3;
            Console.WriteLine(a1);
            Console.WriteLine($"after left shifting:{ Convert.ToString(a1,toBase:2)}");


        }
    }
}
