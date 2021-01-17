using System;

namespace project_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < t; j++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(s[0]),d= Convert.ToInt32(s[1]);
                int[] a = new int[n];
                string[] s1 = Console.ReadLine().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(s1[i]);
                }

                Array.Sort(a);

                if (a[n - 1] <= d)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    if (d >= (a[0] + a[1]))
                    {
                        Console.WriteLine("yes");
                    }
                    else
                    {
                        Console.WriteLine("no");
                    }

                }
            }
        }
    }
}