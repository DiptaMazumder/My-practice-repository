using System;

namespace Add_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                var n = Convert.ToInt32(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                long[] v = new long[n];
                for (int j = 0; j < n; j++)
                {
                    v[j] = Convert.ToInt64(s[j]);
                }

                Array.Sort(v);
                long max = 0;
                for (int j = 0; j < n; j++)
                {
                    if ((v[j] * (n - (j+1) + 1)) > max)
                    {
                        max = v[j] * (n - (j + 1) + 1);
                    }
                }
                Console.WriteLine(max);


            }
        }
    }
}
