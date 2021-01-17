using System;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning some uses of math function");
            var x = 12;
            var y = 32;

            var max = Math.Max(x, y);
            Console.WriteLine(max);
            var min = Math.Min(x, y);
            Console.WriteLine(min);

            var sqrt = Math.Sqrt(16);
            Console.WriteLine($"Square root of 16 is:{sqrt}");

            var abs = Math.Abs(-16);
            Console.WriteLine($"Absolute of -16 is:{abs}");

            var roundvalue = Math.Round(16.49);
            Console.WriteLine($"Round Value of 16.49 is:{roundvalue}");

             roundvalue = Math.Round(16.51);
            Console.WriteLine($"Round Value of 16.51 is:{roundvalue}");

            string s = "Dipta";
            Console.WriteLine(s.Length);//by using Length property we can find the length of a string

            string s1 = "DIpTA MAZuMDEr";
            s1 = s1.ToLower();
            Console.WriteLine($"My name in lowercase: {s1}");
            s1 = s1.ToUpper();
            Console.WriteLine($"My name in uppercase :{s1}");

            //we can concat two string by using (+) operator and also concat() method

            var firstname = "Dipta";
            var lastname = " Mazumder";
            var fullname = firstname + lastname;
            Console.WriteLine($"Full name is: {fullname}");

            fullname = string.Concat(firstname, lastname);
            Console.WriteLine($"Full name is: {fullname}");

            //access strings
            for(int i = 0; i < fullname.Length; i++)
            {
                Console.WriteLine(fullname[i]);
            }
            
            Console.WriteLine($"index position of p is :{s.IndexOf('p')}");

            Console.WriteLine(s.Substring(3));

            Console.Write("String related practice is finished\t");
            Console.WriteLine("Something new is begun");

            var c = "Banglade\bsh";
            Console.WriteLine(c);

            bool b = true;
            Console.WriteLine(b);

            Console.WriteLine(!(10 > 9));

        }
    }
}
