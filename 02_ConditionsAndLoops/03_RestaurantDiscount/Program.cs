using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            string hallName = string.Empty;

            if (groupSize <= 50)
            {
                hallName = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hallName = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hallName = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            double totalPrice = 0;

            if (hallName == "Small Hall")
            {
                totalPrice = 2500;

            }
            else if (hallName == "Terrace")
            {
                totalPrice = 5000;
            }

            else if (hallName == "Great Hall")
            {
                totalPrice = 7500;
            }

            double discount = 0;

            if (package == "Normal")
            {
                totalPrice += 500;
                discount = 0.05;

            }
            else if (package == "Gold")
            {
                totalPrice += 750;
                discount = 0.1;

            }
            else if (package == "Platinum")
            {
                totalPrice += 1000;
                discount = 0.15;
            }

            totalPrice -= totalPrice * discount;
            double pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
