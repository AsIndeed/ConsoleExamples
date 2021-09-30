using System;
using Microsoft.VisualBasic.CompilerServices;

namespace DENEME
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci();
            StaredSquare();


            Console.ReadLine();
        }

        private static void StaredSquare()
        {
            int yukseklik = 20;
            int genislik = 20;

            for (int i = 0; i <= yukseklik-1; i++)
            {
                for (int j = 0; j <= genislik-1; j++)
                {
                    if (i==0 || i == yukseklik-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (j == 0 || j == genislik-1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        private static void Fibonacci()
        {
            int x = 0;
            int y = 1;
            int z;

            for (int i = 0; i < 10; i++)
            {
                z = x + y;
                Console.WriteLine("1. Adım : {0}", z);
                x = y;
                y = z;
            }
        }
    }
}
