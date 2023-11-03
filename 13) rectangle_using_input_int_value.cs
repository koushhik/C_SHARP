
/*
       13. Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit.

       Test Data:
        5

        output:
        555
        5 5
        5 5
        5 5
        555

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());   //We take input from the user of integer type
            Console.WriteLine(a + "" + a + "" + a);        //we then group 3 int in one row together --for first and last rows.
            Console.WriteLine(a + " " + a);                //we group 2 int in next 3 rows but with one space in between to make a triangle
            Console.WriteLine(a + " " + a);
            Console.WriteLine(a + " " + a);
            Console.WriteLine(a + "" + a + "" + a); 
        }
    }

}
