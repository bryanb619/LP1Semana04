using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string s = args[0];

            char c =  char.Parse(args[1]);

            int i = int.Parse(args[2]);
        }

        private static void Decor(string s , char dec, int i)
        {

        }
    }
}
