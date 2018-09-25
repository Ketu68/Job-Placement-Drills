using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalstring, sentence = "I have a dream";
            char[] characterarray1 = sentence.ToCharArray();
            char[] characterarray2;

            for (int x = 0, y = sentence.Length; x < sentence.Length; x++, y--)
            {
                characterarray2[x] = characterarray1[y];
            }

            finalstring = ToString(characterarray2);

            Console.WriteLine("The initital string was : " + sentence);
            Console.WriteLine("The reversed string is : " + finalstring);

            Console.WriteLine("Hit any key to exit...");
            Console.ReadLine();

        }
    }
}
