﻿using System;

namespace Special
{
    class Program
    {
        private static void Main(string[] args)
        {

            // request a number from the user
            Console.Write("Insert a number: ");

            // convert  input to int
            int n = int.Parse(Console.ReadLine());

            // request result from operation => calls GetSpecial(n parameter)
            int result = GetSpecial(n);

            // print result
            Console.WriteLine(result);

        }

        private static int GetSpecial(int n) 
        {


            // temp variable that stores the result
            int calcResult; 

            // return 0 
            if (n== 0)
            {
                calcResult = 0;
            } 

            // return 1
            else if(n == 1)
            {
                calcResult = 1;
            }


            else
            {         
                // calculate special recursively
                calcResult = GetSpecial(n-1) + 2 * GetSpecial(n-2);
             
            }
        
            // return calculation to caller
            return calcResult;
        }
    }
}
