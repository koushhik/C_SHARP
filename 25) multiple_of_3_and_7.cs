
/*
       
             25. Write a C# program to check if a given positive number is a multiple of 3 or 7.

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
            if((a % 3) == 0 || (a % 7) == 0)
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }
        }
         

    }
                                                                                                                                                         
