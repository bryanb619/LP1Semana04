using System;

namespace BetterDecorator
{
    /// <summary>
    ///  Basic Program that receives 3 argument in the console and converts 
    ///  them into string, char and int respectively (s,c,i).
    ///  Passes the variables to Decor function accordingly 
    /// </summary>
    class Program
    {

        /// <summary>
        ///  Main checks if user passed 3 args or more.
        ///  If successful, calls Decor() with the 3 args.
        ///  else, it it call a default Decor(NO param) that will call 
        /// our main Decor(string, char, int) prompting a default reply
        /// </summary>
        /// <param name="args">Used to send 3 variables to decor</param>
        private static void Main(string[] args)
        {

            // check if user passed 3 args or more
            if(args.Length >= 3)
            {
                // indexation & convertion of the variables
                string s = args[0];

                char c =  char.Parse(args[1]);

                int i = int.Parse(args[2]);

                string result = Decor(s, c, i);

                Console.WriteLine(result);

            }

            // else, call a default Decor
            else
            {
                Console.WriteLine(Decor());  
            }
    
            
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

            
            string result = "";

            // add in the left side, dec i times
            for (int a = 0; a < i; a++)
            {
                result += dec;
            }

            result += " " + s + " ";

            // add in the right side, dec i times
            for (int b = 0; b < i; b++)
            {
                result += dec;
            }

            // return the result of the string
            return result;
        }


        /// <summary>
        ///  Method returns a string with a default message while calling the 
        ///  1st Decor method generating a overloading situation
        /// </summary>
        /// <returns>Returns a string, char and a int</returns>
        private static string Decor()
        {
            return Decor("User did not specify args!", '=', 3);   
        }
    }
}
