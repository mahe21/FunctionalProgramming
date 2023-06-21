using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class HarmonicNumbers
    {
        public void HarmonicNumber() 
        {
            int NthNumber = 10;
            float Num = 0;
            for (int i = 1; i <= NthNumber; i++)
            {
                Num += (float)1 / i;

            }
            Console.WriteLine(Num);
        }
    }
}
