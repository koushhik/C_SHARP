
/*
        8. Write a C# Sharp program that prints the multiplication table of a number as input.

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); //HERE WE TAKE INPUT FROM THE USER
            for(int i = 1;i <= 10; i++)                  //WE USE A FOR LOOP FOR REDUCING CODING COMPLEXITY (simple coding practice)
            {                                             // START BY STARTING THE RANGE FROM ONE AND END TILL 10 , AND AFTER EACH VALUE OF i THE PRINTING IS DONE
                Console.WriteLine(a + " * " + i + " = " + a*i);  //WE PRINT THE VALUE BY TRADIONAL TABLES FORMAT ...WE MULTIPLY THE VALUE OF i AND a AT EVERY STEP.
            }
           
        }
    }

}
