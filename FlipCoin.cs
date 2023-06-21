using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class FlipCoin
    {
        public void CoinPercentage()
        {
            
            int no_Of_Flips = 100;

            if (no_Of_Flips <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }
            Random random = new Random();
            int headsCount = 0;
            int tailsCount = 0;

            for (int i = 0; i < no_Of_Flips; i++)
            {
                double flipResult = random.Next(0, 2);

                if (flipResult < 0.5)
                    tailsCount++;
                else
                    headsCount++;
            }

            double headsPercentage = (double)headsCount / no_Of_Flips * 100;
            double tailsPercentage = (double)tailsCount / no_Of_Flips * 100;

            Console.WriteLine($"Heads: {headsPercentage}%");
            Console.WriteLine($"Tails: {tailsPercentage}%");
        }
    }
}
