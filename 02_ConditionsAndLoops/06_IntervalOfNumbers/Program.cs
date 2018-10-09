using System;

namespace _06_IntervalOfNumbers
{
    class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int fromNum = Math.Min(num1, num2);
            int toNum = Math.Max(num1, num2);

            for (int i = fromNum; i <= toNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
