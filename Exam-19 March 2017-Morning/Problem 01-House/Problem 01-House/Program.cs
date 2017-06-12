using System;
namespace house
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var height = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var heightOfTriangle = double.Parse(Console.ReadLine());

            var sideWall = height * length;
            var window = 1.5 * 1.5;
            var twoSideWall = (sideWall * 2) - (window * 2);
            var rearWall = height * height;
            var door = 1.2 * 2;
            var sideRear = 2 * rearWall - door;
            var totalArea = twoSideWall + sideRear;
            var greenPaint = totalArea / 3.4;

            var rectanglesRoof = 2 * (height * length);
            var twoTriangles = 2 * (height * heightOfTriangle / 2);
            var totalRoofArea = rectanglesRoof + twoTriangles;
            var redPaint = totalRoofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
