using System;

namespace _09_CountTheIntegers
{
    class Program
    {
        static void Main()
        {
            int counter = 0;

            try
            {
                int input = int.Parse(Console.ReadLine());

                while (true)
                {
                    counter++;
                    input = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine(counter);
            }
        }
    }
}
