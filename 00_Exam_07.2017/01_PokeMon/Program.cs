using System;

namespace PokeMon
{
    class Program
    {
        static void Main()
        {
            int initialPowerN = int.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            int exhaustionFactorY = int.Parse(Console.ReadLine());

            int pokePowerN = initialPowerN;
            int counter = 0;

            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;

                counter++;

                if (initialPowerN / 2 == pokePowerN
                    && initialPowerN % 2 == 0
                    && exhaustionFactorY != 0)
                {
                    pokePowerN /= exhaustionFactorY;
                }
            }

            Console.WriteLine(pokePowerN);
            Console.WriteLine(counter);
        }
    }
}       // 100%
