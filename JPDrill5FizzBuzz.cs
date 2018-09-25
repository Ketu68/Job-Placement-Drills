using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that prints the numbers from 1 to 100.But for multiples of three print "Fizz"
            //instead of the number and for the multiples of five print "Buzz".For numbers which are multiples 
            //of both three and five print "FizzBuzz"

            List<int> numberslist = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                numberslist.Add(i);
            }

            Console.WriteLine("The original list is : ");
            foreach (int x in numberslist)
            {
                Console.Write("{0} ", x.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The FizzBuzzed list is : ");
            Console.WriteLine();

            foreach (int y in numberslist)
            {
                if ((y % 3 == 0) && (y % 5 == 0)) Console.WriteLine("FIZZBUZZ");
                else if (y % 3 == 0) Console.WriteLine("FIZZ");
                else if (y % 5 == 0) Console.WriteLine("BUZZ");
                else Console.WriteLine(y);

                //Console.Write("{0} ", y.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hit any key to exit...");
            Console.ReadLine();
        }
    }
}
