/*
         7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());  //HERE WE USE READLINE TO TAKE TWO NUMBER a and b AS INPUT FROM THE USERS
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + b);                      //WE USE MATHEMATICAL OPRATORS + - * / and % FOR ADD, SUB , MUL DIV AND MODULUS(REMAINDER) respectivley. 
            Console.WriteLine(a - b);                      //WE THEN PRINT THE RESULT IN WRITELINE.
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }

}
