
/*    
             27.  Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Runtime.Remoting.Services;
using System.Xml.Schema;
          //new program 
namespace Practice
{
    class Program
    {
        public void charr()
        {
          Console.WriteLine("ENTER YOUR STRING :");
            string str = Console.ReadLine();              //reading the string
            if(str.Length <= 4)                           //if string length is less than 4 we convert it to UPPER CASE
            {
                Console.WriteLine(str.ToUpper());           //string function to convert string to upper case.
            }
            else
            {
                Console.WriteLine(str.Substring(0,4).ToLower() + str.Substring(4, str.Length -4)); //If string is greater than 4 we create a reange uising substring
                                               //That is first 4 char in string will be in lower case while the reamining string from (4 to string length - 4) would be as it is. 
            }
        }

        public static  void Main(string[] args)
        {
            Program lw = new Program();
            lw.charr();
        }

    }
}

