using System;
using System.Globalization;

namespace BetterDecorator
{
    class Program
    {
        private static void Main(string[] args)
        {

            // indexation
            string s = args[0];

            char c =  char.Parse(args[1]);

            int i = int.Parse(args[2]);

            // calling Decor method
            Decor(s, c, i);
        }


        private static void Decor(string s , char dec, int i)
        {

            // add in each side of the string the character dec i times

            for (int x = 0; i < x; x++)
            {
                // TODO: add ESPACE BEFORE AND AFTER THE STRING
                s = dec + s + dec;
            }

            Console.WriteLine(s);


        }
    }
}
