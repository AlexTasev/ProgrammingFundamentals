using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ChoseADrink
{
    class Program
    {
        static void Main()
        {
            string proffesion = Console.ReadLine();
            string drink = string.Empty;

            switch (proffesion)
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
        }
    }
}
