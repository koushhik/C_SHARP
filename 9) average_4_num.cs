
/*
        9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());  //TAKE 4 INTEGERS AS INPUT FROM THE USERS
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((a + b + c + d)/4);        //CALCULATE THE AVERAGE BY USING THE FORUMLA : (NUM1 + NUM2 + NUM3 + NUM4) DIVIDED BY 4 NUMBERS.
           
        }
    }

}
