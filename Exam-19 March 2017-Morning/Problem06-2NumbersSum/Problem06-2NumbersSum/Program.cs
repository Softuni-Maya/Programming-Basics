using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem06_2NumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int begining = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            for (int i = begining; i >= end; i--)
            {
                for (int j = begining; i >= end; i--)
                {
                    var sum = i + j;
                    if (sum == magicNumber)
                    {

                    }
                }
            }
        }
    }
}
