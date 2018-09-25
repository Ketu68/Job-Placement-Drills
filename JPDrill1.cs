using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int[] Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int x=0;  x < Numbers.Length; x++)
            {
                if (Numbers[x] % 2 != 0) total += Numbers[x];
            }

            Console.WriteLine("The total of the odd numbers is : " + total);
            Console.WriteLine("Hit any key to exit...");
            Console.ReadLine();

        }
    }
}
