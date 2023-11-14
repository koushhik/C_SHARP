/*
          4. Write a C# Sharp program to print the results of the specified operations.
          Test data:

         -1 + 4 * 6
         ( 35+ 5 ) % 7
         14 + -4 * 6 / 11
         2 + 15 / 6 * 1 - 7 % 2

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            Console.WriteLine(-1 + 4 * 6);   //FOR THE GIVEN TEST CASES ENTER THE OPERATIONS , HERE THE COMPILOR IS MART ENOUGH TO CHECK WHICH-
            Console.WriteLine((35 + 5) % 7);         //cont......RULE NEEDS TO BE CHECKED FIRST.
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
    }

}
