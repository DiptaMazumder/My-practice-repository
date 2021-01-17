using System;
using System.Linq;

namespace project5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] v = new int[n];

            for(int i = 0; i < n; i++)
            {
                v[i]= Convert.ToInt32(Console.ReadLine());
            }

            //output
            Console.WriteLine("output:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

            Console.WriteLine($"maximum value of array is :{v.Max()}");
            Console.WriteLine($"manimum value of array is :{v.Min()}");
            Console.WriteLine($"sum  of array element is :{v.Sum()}");

            Array.Sort(v);
            Console.WriteLine($"After sorting:");

            for(int i = 0; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
            }
        }
    }
}
