
/*
       
              19. Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.

 */

using System;
using System.Collections.Generic;

namespace Practice
{
    class program
    { 
        public static void Main(string[] args)               
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if(a == 20 || b == 20)  //WE CHECK BY COMPARING IF A OR B IS EQUAL TO 20 IN THE IF CASE
            {
                Console.WriteLine("True");
            }
            else if(a+b == 20)    //WE THEN CHECK IF A AND B SUM WILL BE EQUAL TOO 20 IF IF ELSE CASE
            {
                Console.WriteLine("True");
            }
            else    // ALL OTHER CONDITIONS ARE PRINTED IN ELSE CASE.
            {
                Console.WriteLine("False");
            }
           
        }
            
    }

}
