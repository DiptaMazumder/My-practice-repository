using System;

namespace Cancel_the_Trains
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(s[0]), m = Convert.ToInt32(s[1]);
                string[] n1 = Console.ReadLine().Split(' ');
                int[] a = new int[n];
                for (int j = 0; j < n; j++)
                {
                    a[j]= Convert.ToInt32(n1[j]);
                    
                }

                string[] m1 = Console.ReadLine().Split(' ');
                int[] a1 = new int[m];
                for (int j = 0; j < m; j++)
                {
                    a1[j] = Convert.ToInt32(m1[j]);
                }
                int c = 0;
                foreach (var iA in a) {
                    foreach (var iB in a1)
                    {
                        if (iA == iB)
                        {
                            c++;
                        }
                    }
                }


                Console.WriteLine(c);

            }
        }
    }
}
