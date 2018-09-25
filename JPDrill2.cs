using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            numlist[] = { 31400, 1700, 2800, 42768, 312454 };
            TotalArray(numlist);

        }

        long TotalArray(int numarray[])
        {
            long total = 0;
            for (int x = 0; x< numarray.Length; x++)
            {
                total += numarray[x];
            }
            return total;
        }
    }
}