using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ChooseADrinkTwo
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }

            double price = 0;

            //  Water	Coffee	Beer	Tea
            //  0.70    1.00    1.70    1.20

            switch (drink)
            {
                case "Water":
                    price = 0.7;
                    break;
                case "Coffee":
                    price = 1.0;
                    break;
                case "Beer":
                    price = 1.7;
                    break;
                case "Tea":
                    price = 1.2;
                    break;
            }

            double totalPrice = price * quantity;

            Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
        }
    }
}
