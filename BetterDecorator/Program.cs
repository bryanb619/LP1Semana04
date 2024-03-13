using System;

namespace BetterDecorator
{
    /// <summary>
    ///  Basic Program
    /// </summary>
    class Program
    {

        /// <summary>
        ///   
        /// </summary>
        /// <param name="args">Used to send 3 variables to decor</param>
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
        ///  Receives 3 types of variables and returns a 
        /// string concatenated in each side with with a char i times
        /// </summary>
        /// <param name="s"> To be received from user </param>
        /// <param name="dec">Added in each side of the string s</param>
        /// <param name="i">Controls how many times the char is repeated in each side </param>
        /// <returns>returns a string concatenated in each side with with a char</returns>
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
