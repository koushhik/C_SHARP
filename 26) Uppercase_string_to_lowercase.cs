/*
       26.Write a C# program to convert a given string into lowercase.
 
*/




using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Net;

namespace Practice
{
    class Program
    {
        public void stringCase()                                  //this is the method/funtion declairation [SYNTAX : Access_specifier return_type functionname() {}]
        {
            Console.WriteLine("ENTER THE STRING IN UPPERCASE");  //THIS IS A LINE FOR USER TO UNDERSTAND IN WRITING THE STRING IN UPPER CASE
            string str = Console.ReadLine();                     //STATEMENT TO READ INPUT FROM THE USER
            Console.WriteLine(str.ToLower());                    //CONVERT THE STRING INTO LOWER CASE
        }

        public static  void Main(string[] args)
        {
            Program lw = new Program();                        //here we use object declairation for a class [SYNTAX : classname objectname = new classname() ] 
            lw.stringCase();                                   //we access the function stringCase() using the object [SYNTAX : objectname.functionname();] 
        }

    }
}

