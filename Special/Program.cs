using System;

namespace Special
{
    class Program
    {
        private static void Main(string[] args)
        {

            // request a number from the user
            Console.WriteLine("Insert a number: ");

            // convert  input to int
            int n = int.Parse(Console.ReadLine());

            // request result from operation
            int result = GetSpecial(n);


        }

        private static int GetSpecial( int n)
        {

        
            return n;
        }
    }
}
