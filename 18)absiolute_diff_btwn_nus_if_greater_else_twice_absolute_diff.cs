/*
       
               18. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.

 */

using System;
using System.Collections.Generic;

namespace Practice
{
    class program
    { 
        public static void Main(string[] args)               
        {
            int a = Convert.ToInt32(Console.ReadLine());   //WE TAKE TWO INTEGER AS INPUT VALUES
            int b = Convert.ToInt32(Console.ReadLine());

            if(a > b)                                      //COMPARING THE VALUES TO SEE IF A IS GREATER THAN B
            {
                Console.WriteLine((a - b) * 2);            //IF A IS GRETAER THAN B THEN WE SUBSTRACT AND MULTIPLY THEM TWICE.
            }
            else
            {
                Console.WriteLine((b - a));   //HERE WE ALREADY KNOW THAT A IS NOT GREATER THAN B , BUT TO AVOID NEGATIVE NUMBERS WE DO REVERES SUBSTRACT TO GET ABSOLUTE VALUE WITHOUT BUILT IN FUNCTION.
            }
        }
            
    }

}
