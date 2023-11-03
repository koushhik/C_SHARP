
/*
 
                        15. Write a C# program that removes a specified character from a non-empty string using the index of a character

 */

using System;

namespace Practice
{
    class program
    { 
        public static void Main(string[] args)                    //ALWAYS THE CONTENT IN THIS BLOCK OF CODE IS EXECUTED FIRST
        {
            Console.WriteLine(rem_char("DICTIONARY", 1));         //THE STRING NAME AND THE INDEX AT WHICH CHAR NEEDS TO BE DELETED IS SENT AS ARGUMENT TO rem_char Function.
            Console.WriteLine(rem_char("DICTIONARY", 5));
            Console.WriteLine(rem_char("DICTIONARY", 7));
        }

        public static string rem_char(string str, int n)         //HERE THE FUNCTION rem char is efined along with THE DATA TYPE OF THE PASSED ARGUMENTS FROM MAIN FUNCTION
        {
            return str.Remove(n, 1);                             ////IN STRING Remove(the-location_at_which_char_needs to be removed, how many characters needs to be removed is specified) 
        }
            
    }

}

