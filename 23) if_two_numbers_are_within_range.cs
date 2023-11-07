/*
       
             23. Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.

 */

using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if((y <= 10 && y >= -10) && (x <= 10 && x >= -10))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
         

    }
}
