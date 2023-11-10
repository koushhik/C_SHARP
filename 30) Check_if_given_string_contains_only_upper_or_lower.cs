/*    
             30. Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.
*/

using System;
using System.Linq;
using System.Diagnostics.CodeAnalysis;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(stringCase("JOHNWICK"));           //3. we check if the given 3 string satisifies the upper case or lower case 
            Console.WriteLine(stringCase("albusdumbledoor"));    //4. If the string contains upper case or lower case it will return true.
            Console.WriteLine(stringCase("JackSparrow"));        //5. if the string contains the mixture of upper and loer it will return false.

        }
        public static bool stringCase(string str)                // 1.we first create a method of boolen type with method name : stringCase.
        {
            return str == str.ToLower() | str == str.ToUpper();  // 2.here we check if string is eigther is upper case or lower case .
        }
       
    }
}
// 1.we first create a method of boolen type with method name : stringCase.
// 2.here we check if string is eigther is upper case or lower case .
// 3. we check if the given 3 string satisifies the upper case or lower case 
// 4. If the string contains upper case or lower case it will return true.
// 5. if the string contains the mixture of upper and loer it will return false.
