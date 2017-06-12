using System;


namespace house
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfCups = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            double workingDays = double.Parse(Console.ReadLine());

            double workingHours = numberOfWorkers * workingDays * 8;
            var cups = workingHours / 5;
            cups = Math.Truncate(cups);

            if (cups < numberOfCups)
            {
                var losses = (numberOfCups - cups) * 4.2;
                Console.WriteLine("Losses: " + "{0:f2}", losses);
            }
            else
            {
                var profit = (cups - numberOfCups) * 4.2;
                Console.WriteLine($"{profit:f2} extra money");
            }

        }
    }
}
