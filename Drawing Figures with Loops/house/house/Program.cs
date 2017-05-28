using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//input

            var stars = 1;
            if (n % 2 == 0) stars++;
            for (var roof = 0; roof < (n + 1) / 2; roof++)// for roof
            {
                var padding = (n - stars) / 2;
                Console.Write(new string('-', padding));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', padding));
                stars = stars + 2;
            }// end for roof

            for (var house = 0; house < n / 2; house++)
            {
                Console.Write("|");
                for (var col = 0; col < n - 2; col++)
                {
                    Console.Write("*");
                }//end for col
                Console.WriteLine("|");
            }//end for house
        }
    }
}
