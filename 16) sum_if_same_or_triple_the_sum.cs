
/*
 
                       16. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum

                        Test Case:
                         4
                         4
                        result : 24

                        Test case 2:
                         2
                         3
                        result : 5

 */

using System;

namespace Practice
{
    class program
    { 
        public static void Main(string[] args)               
        {

            int a = Convert.ToInt32(Console.ReadLine()); //take two integers as input from the users of integer type
            int b = Convert.ToInt32(Console.ReadLine());
           
            if(a == b)                                   //using if statement to compare if both integers are equal or not...!
            {
                Console.WriteLine((a+b)*3);              //if both the integers are equal then, return trible of the whole sum , meaning add two integers and multiply by 3
            }
            else                                         //in else case all the possiblities where a and b are not equal will be executed 
            {
                Console.WriteLine(a + b);                //in case where a and b are  not equal then add them and display sum.
            }
        }
            
    }

}
