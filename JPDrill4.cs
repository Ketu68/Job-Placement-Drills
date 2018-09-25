using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "ABBCCCDDEFGHIIIJKLLLMMNOPPPQRSSSTTTUVWXYZZZ";
            string text2 = string.Empty;
            
            text2 = removeduplicateletters(text1);

            Console.WriteLine("Original string was : " + text1);
            Console.WriteLine("Stripped of duplicates string is : " + text2);
            Console.ReadLine();
        }

        static string removeduplicateletters(string s)
        {
            string returnstring = string.Empty;
            List<char> found = new List<char>();
            foreach (char c in s)
            {
                if (found.Contains(c)) continue;

                returnstring += c.ToString();
                found.Add(c);
            }
            return returnstring;
        }
    }
}
