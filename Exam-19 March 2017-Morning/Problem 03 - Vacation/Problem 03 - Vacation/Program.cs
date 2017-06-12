using System;


namespace house
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string locations = null;
            string place = null;
            var price = 0.0;


            if (budget <= 1000)
            {
                locations = "Camp";
                if (season == "Summer")
                {
                    place = "Alaska";
                    price = 0.65 * budget;
                    Math.Round(price, 2);
                }
                else if (season == "Winter")
                {
                    place = "Morocco";
                    price = 0.45 * budget;
                    Math.Round(price, 2);
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                locations = "Hut";
                if (season == "Summer")
                {
                    place = "Alaska";
                    price = 0.80 * budget;
                    Math.Round(price, 2);
                }
                else if (season == "Winter")
                {
                    place = "Morocco";
                    price = 0.60 * budget;
                    Math.Round(price, 2);
                }
            }
            else if (budget > 3000)
            {
                locations = "Hotel";
                if (season == "Summer")
                {
                    place = "Alaska";
                    price = 0.90 * budget;

                }
                else if (season == "Winter")
                {
                    place = "Morocco";
                    price = 0.90 * budget;

                }
            }
            Console.WriteLine(place + " - " + locations + " - " + "{0:f2}", price);
        }
    }
}
