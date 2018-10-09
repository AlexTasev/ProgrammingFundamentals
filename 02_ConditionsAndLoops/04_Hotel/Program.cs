using System;

namespace _04_Hotel
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;


            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceDouble = 65;
                priceSuite = 75;

                if (nightsCount > 7)
                {
                    priceStudio -= priceStudio * 0.05;
                }
            }

            else if (month == "June" || month == "September")
            {
                priceStudio = 60;
                priceDouble = 72;
                priceSuite = 82;

                if (nightsCount > 14)
                {
                    priceDouble -= priceDouble * 0.1;
                }
            }
            else if (month == "July" || month == "August" || month == "December")
            {
                priceStudio = 68;
                priceDouble = 77;
                priceSuite = 89;

                if (nightsCount > 14)
                {
                    priceSuite -= priceSuite * 0.15;
                }
            }
            if (month == "September" && nightsCount > 7)
            {
                priceStudio *= nightsCount - 1;
            }
            else if (month == "October" && nightsCount > 7)
            {
                priceStudio *= nightsCount - 1;
            }
            else
            {
                priceStudio *= nightsCount;
            }

            priceDouble *= nightsCount;
            priceSuite *= nightsCount;

            Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            Console.WriteLine($"Double: {priceDouble:f2} lv.");
            Console.WriteLine($"Suite: {priceSuite:f2} lv.");
        }
    }
}
