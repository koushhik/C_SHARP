
/*
       
             24. Write a C# program to find the largest and lowest values from three integer values

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
            int c = Convert.ToInt32(Console.ReadLine());

            if(a > b && b > c)
            {
                Console.WriteLine(a + " IS THE LARGEST");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine(b + " IS THE LARGEST");
            }
            else
            {
                Console.WriteLine(c + " IS THE LARGEST");
            }

            if( a < b && a <c)
            {
                Console.WriteLine(a + " IS THE SMALLEST");
            }
            else if(b < a && b < c)
            {
                Console.WriteLine(b + " IS THE SMALLEST");
            }
            else
            {
                Console.WriteLine(c + " IS THE SAMLLEST");
            }
        }
         

    }
}
