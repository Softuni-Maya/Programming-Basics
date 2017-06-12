using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04_TrainersSal
{
    class Program
    {
        static void Main(string[] args)
        {
            int lectures = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            var sumOneLectures = budget / lectures;

            var Jelev = 0;
            var RoYaL = 0;
            var Roli = 0;
            var Trofon = 0;
            var Sino = 0;
            var Others = 0;

            for (int i = 0; i < lectures; i++)
            {
                string lecturer = Console.ReadLine();

                if (lecturer == "Jelev")
                { Jelev++; }
                else if (lecturer == "RoYal")
                { RoYaL++; }
                else if (lecturer == "Roli")
                { Roli++; }
                else if (lecturer == "Trofon")
                { Trofon++; }
                else if (lecturer == "Sino")
                { Sino++; }
                else
                { Others++; }
            }
            Console.WriteLine("Jelev salary: {0:f2} lv", Jelev * sumOneLectures);
            Console.WriteLine("RoYaL salary: {0:f2} lv", RoYaL * sumOneLectures);
            Console.WriteLine("Roli salary: {0:f2} lv", Roli * sumOneLectures);
            Console.WriteLine("Trofon salary: {0:f2} lv", Trofon * sumOneLectures);
            Console.WriteLine("Sino salary: {0:f2} lv", Sino * sumOneLectures);
            Console.WriteLine("Others salary: {0:f2} lv", Others * sumOneLectures);

        }
    }
}
