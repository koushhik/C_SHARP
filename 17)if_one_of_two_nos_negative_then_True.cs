/*
       
               17. Write a C# program to check a pair of integers and return true if one is negative and one is positive.
       
      Sample Output:
        Input first integer:
        -5
        Input second integer:
        25
        Check if one is negative and one is positive:
        True

 */

using System;

namespace Practice
{
    class program
    { 
        public static void Main(string[] args)               
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if((a < 0 && b > 0) || (a > 0 && b < 0))   //HERE WE CHECK FOR COONDITION :A IS NOT NEGATIVE WHICH MEANS LESSER TAHN O A IS POSITIVE MEANS A GRETER THAN 0( > 0)
            {
                Console.WriteLine("True");             //If one is negative or other one is negative we return TRUE
            }
            else
            {
                Console.WriteLine("False");            //if both are positive or both negative then, false is printed
            }
        }
            
    }

}

