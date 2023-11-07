
/*
       
              22. Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.

 */

using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if((a < 100) && (b > 100))
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
