using System;

namespace project_8
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();
                

                if (string.IsNullOrEmpty(number1) ||
                    string.IsNullOrEmpty(number2))
                    break;

                if (number1.Length < number2.Length)
                {
                    var temp = number1;
                    number1 = number2;
                    number2 = temp;
                }

                int[] result = new int[number1.Length];
               /* for(int k = 0; k < +result[i]; k++)
                {
                    Console.WriteLine(result[k]);
                }*/
                

                var i = number1.Length - 1;
                var j = number2.Length - 1;
                
                var finalCarry = false;
                while (i >= 0)
                {
                    var sum = 0;
                        var c1=0;
                    if (j >= 0 && ((number1[i] - '0') - (number2[j] - '0'))>=0)
                    {
                        sum = (number1[i] - '0') - (number2[j] - '0') - result[i];
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        sum = (number1[i] - '0'+10) - (number2[j] - '0') + result[i];
                        c1++;
                        Console.WriteLine(sum);
                    }

                    if (c1>0)
                    {
                        sum = sum % 10;

                        if (i - 1 >= 0)
                            result[i - 1] = 1;
                        else
                            finalCarry = true;
                    }

                    if (i >=0)
                    {
                        result[i] = sum;
                    }
                   

                    i--;
                    j--;
                }



                for (var x = 0; x < result.Length; x++)
                {
                    Console.Write(result[x]);
                }

                Console.WriteLine();
            }
        }
    }
}
