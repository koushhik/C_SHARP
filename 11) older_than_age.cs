
/*
       11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".

*/

using System;
//using display trick to ,show age .

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());       //HERE THE MAIN GOAL IS TO TAKE INPUR FROM THE USER THROUGH READLINE AND STORE IT IN AN INTEGER VARIABLE. 
            Console.WriteLine("You look older than " + a);     //THEN TO DIAPLAY THE MENTION LINE ...THE KEY IS TO UNDERSTAND BASIC INPUT OUTPUT OPERATIONS AND SPACING.
        }
    }

}
