using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {//this all are implicit type casting
            char ch = 'd';
            int a = ch;
            long l = a;
            float f = l;
            double d = f;
            Console.WriteLine(d);

            //these all are explicit type casting example
            double d1 = 97.775;
            float f1 =(float) d1;
            long l1 = (long)f1;
            Console.WriteLine(l1);
            int a1 =(int) l1;
            Console.WriteLine(a1);
            char ch1 = (char)a1;
            Console.WriteLine(ch1);

            //But we can also do explicit type casting by using some built in method
            double d2 = 97.335;
            float f2 = (float)d2;
            long l2 = Convert.ToInt64(f2);
            Console.WriteLine(l2);
            int a2 = Convert.ToInt32(l2);
            Console.WriteLine(a2);
            char ch2 = Convert.ToChar(a2);
            Console.WriteLine(ch2);

            string s = "13434";
            long x =Convert.ToInt64(s);
            Console.WriteLine(x);

        }
    }
}
