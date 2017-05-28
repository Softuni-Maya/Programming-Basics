using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//input

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < 5 * n; col++)
                {
                    if (col >= 2 * n && col < 3 * n)
                    {
                        if (row == (n - 1) / 2)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }//end if

                    else if (row == 0 || row == n - 1 || col == 0 || col == (2 * n) - 1 ||
                             col == 3 * n || col == (5 * n) - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("/");
                    }

                }//end for col
                Console.WriteLine();
            }//end col row


        }
    }
}