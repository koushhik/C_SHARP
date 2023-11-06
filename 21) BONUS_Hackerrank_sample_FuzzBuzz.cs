/*
       
              21 . BONUS : HACKER RANK FIZZ BUZZ SAMPLE QUESTION ANSWER.

 */

using System;
using System.Collections.Generic;

namespace Practice
{
    class program
    {
        public int ultiple(int n)
        {

            for(int i = 1; i <= n; i ++)   //WE START THE LOOP FROM 1 TILL N (INCLUDING N)
                {
                  if((i % 3 == 0) && (i % 5 == 0)) // WE TEST FOR EVRY VALUE OF I , THAT IS IF I VALUE IS MULTIPLE OF BOTH ( 3 AND 5 )
                {
                    Console.WriteLine("FuzzBuzz");
                }
                  else if((i % 3 == 0) && (i % 5 != 0)) //WE TEST IF 3 IS A MULTIPLE BUT WHEN 5 IS NOT
                {
                    Console.WriteLine("Fuzz");
                }
                  else if((i % 5 == 0) && (i % 3 != 0)) //WE TEST IF 5 IS A MULTIPLE BUT 3 IS NOT A MULTIPLE .
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);  // IF ITS NEIGHTER MULTIPLE OF 3 OR 5 OR BOTH THEN WE DISPLAY THE I VALUE.
                }
                
                }
            return n;
        }

        public static void Main(string[] args)               
        {
            int n = Convert.ToInt32(Console.ReadLine());
            program x = new program();                               //WE CREATE AN OBJECT
            x.ultiple(n);                                            //WE ACESS THE FUNCTION USING OBJECT
        }
           
        
        
    }

}



