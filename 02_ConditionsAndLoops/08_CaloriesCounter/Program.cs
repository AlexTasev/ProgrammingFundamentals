﻿using System;

namespace _08_CaloriesCounter
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int totalCaloriesAmount = 0;

            for (int i = 0; i < n; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":
                        totalCaloriesAmount += 500;
                        break;
                    case "tomato sauce":
                        totalCaloriesAmount += 150;
                        break;
                    case "salami":
                        totalCaloriesAmount += 600;
                        break;
                    case "pepper":
                        totalCaloriesAmount += 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {totalCaloriesAmount}");
        }
    }
}
