/*
         6) Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user 

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); //WE TAKE INPUTS FROM THE USERS FOR 3 VALUES OF INTEGER TYPE
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a * b * c); //WE USE * OPERATOR FOR MULTIPLICATION OF 3 VALUES a ,b AND c THUS a*b*b and display the result
        }
    }

}
