using System;
//using java.lang;
using System.Collections.Generic;
using System.Linq;


namespace _1st_problem_assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter two integer number:");
                var n1 = Console.ReadLine();
                var n2 = Console.ReadLine();
                int n = 0;
                for (int i = n1.Length - 1; i >= 0; i--)
                {
                     n = (Convert.ToInt32(n1[i]) - 48) ;
                    Console.WriteLine(n);
                }

                for (int i = n2.Length - 1; i >= 0; i--)
                {
                     n = (Convert.ToInt32(n2[i]) - 48) ;
                    Console.WriteLine(n);
                }
               

                int j = n1.Length - 1;
                int k = n2.Length - 1;
                int c = 0;

                int[] result = new int[j];

                if (j >= k)
                {
                    for(int i = j; i >= 0; i--)
                    {
                        if (n1[i] < n2[i])
                        {
                            n =10+ ((Convert.ToInt32(n1[i]) - 48) % 10);
                           result[i] = n - (Convert.ToInt32(n2[i]) - 48) - c;
                            c++;
                            
                        }
                    }
                }

                for(int i = 0; i < j; i++)
                {
                    Console.WriteLine(result[i]);
                }


            }
        }
    }
}
