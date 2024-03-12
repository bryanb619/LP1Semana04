using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


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
            for (int x = 0; x < i; x++)
            {
                s = dec + s + dec;
            }


        }
    }
}
