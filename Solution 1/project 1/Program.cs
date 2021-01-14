using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Dipta Mazumder");
            string s = "Dipta";
            string s1 = " Mazumder";
            string s2 = s + s1;
            Console.WriteLine(s2);
            int x = 15,y=20;
            int z = x + y;
            Console.WriteLine(z);
            const int a = 45;
            //int a = 34;
            Console.WriteLine(a);
            int D= 5;
            Console.WriteLine(D);
            int ASdf = 454;
            Console.WriteLine(ASdf);
            double b = 4.55;
            Console.WriteLine(b);

            long myNum = 15000000000;
            Console.WriteLine(myNum);

            float myNum1 = 5.75757777777f;//6 digit after decimal point
            Console.WriteLine(myNum1);

            double myNum2 = 5.75757777777;
            Console.WriteLine(myNum2);

            float f1 = 35e4f;
            Console.WriteLine(f1);
            double f2 = 12E4;
            Console.WriteLine(f2);

        }
    }
}
