
/*    
             29. Write a C# program to compute the sum of all the elements of an array of integers.
*/

using System;
using System.Diagnostics.CodeAnalysis;

namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, };        //DECLAIRE AN ARRAY
            int sum = 0;                                                              //INITIALIZE THE VALUE OF SUM TO ZERO                   
            Console.WriteLine("ADDITION OF ALL THE ELEMENTS OF THE ARRAY GIVES :");
            for (int i = 0; i < arr1.Length; i++)                                      //LOOP THROUGH ALL THE ELEMNTS IN AN ARRAY
            { sum += arr1[i]; }                                                       //ADD THE VALUE OF SUM TO THE ARRAY ELEMENTS                       
            Console.WriteLine(sum);

        }
       
    }
}

