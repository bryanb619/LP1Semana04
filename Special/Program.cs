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

            // print result
            Console.WriteLine(result);


        }

        private static int GetSpecial(int n)
        {

            int calcResult; 

            if (n== 0)
            {
                calcResult = 0;
            } 
        
            return n;
        }
    }
}
