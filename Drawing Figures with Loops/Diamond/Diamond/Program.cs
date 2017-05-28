using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//input

            int leftRight = (n - 1) / 2;


            for (int row1 = 0; row1 < (n - 1) / 2; row1++)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight--;
            }//end for row1

            for (int row2 = (n - 1) / 2; row2 >= 0; row2--)
            {
                Console.Write(new string('-', leftRight));
                Console.Write("*");
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', leftRight));
                leftRight++;
            }
        }
    }
}