using System;

namespace FizzBuzz
{
    class FIzzBuzz
    {
        static void Main(string[] args)
        {
            for (int o = 1; o <= 100; o++)
            {
                if (o % 3 == 0 && o % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz\n");
                }
                else if (o % 3 == 0)
                {
                    Console.WriteLine("fizz\n");
                }
                else if (o % 5 == 0)
                {
                    Console.WriteLine("buzz\n");
                }

                else
                {
                    Console.WriteLine(o + "\n");
                }


            }

        }
    }
}