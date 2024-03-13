using System;

namespace BetterDecorator
{
    /// <summary>
    ///  Basic Program, 
    /// </summary>
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {

            // indexation
            string s = args[0];

            char c =  char.Parse(args[1]);

            int i = int.Parse(args[2]);

            string result = Decor(s, c, i);

            Console.WriteLine(result);
        }


        /// <summary>
        /// Adds a character to the beginning and end of a string
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="dec"></param>
        /// <param name="i"></param>
        private static string Decor(string s , char dec, int i)
        {

            // add in each side of the string the character dec i times
            string result = "";

            for (int a = 0; a < i; a++)
            {
                result += dec;
            }

            result += " " + s + " ";

            for (int b = 0; b < i; b++)
            {
                result += dec;
            }

            return result;
        }


        private static string Decor()
        {
            return "User";
        }
    }
}
