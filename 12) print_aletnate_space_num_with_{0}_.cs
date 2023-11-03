/*
       12. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}.
        
        
        Test Data:
        
        Enter a digit :
        35
        
        output:
        35 35 35 35
        35353535
        35 35 35 35
        35353535
*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER A DIGIT :");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num + " " + num + " " + num + " " + num);  // method A: here we display the numbers with smart simple spacing.
            Console.WriteLine(num + "" + num + "" + num + "" + num);      // method B: here diplay numbers in crowded format withot spacing

            Console.WriteLine("{0} {0} {0} {0}",num);           //method C: here the notation {0} means the variables declaired at the 1 st will be displayed...at that location 
            Console.WriteLine("{0}{0}{0}{0}", num);              //method D: you can many variables and keep on mentioning {1} {2} {3} etc...its index is similar to arrays.
      
          
        }
      
    }

}
