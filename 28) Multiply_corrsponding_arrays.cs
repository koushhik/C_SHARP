
/*    
             28. Write a C# program to multiply the corresponding elements of two integer arrays.
*/

using System;



namespace Practice
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };                          //DECLAIRE THE FIRST ARRAY
            int[] arr2 = { 2, 4, 6, 8 };                          //DECLAIRE THE SECOND ARRAY
            Console.WriteLine("ARRAY AFTER MULTIPLICATION IS :");
            for (int i = 0; i < arr1.Length; i++)                 //STRAT  A LOOP TO ACESS THE ELEMENTS OF THE ARRAY
            {
                Console.WriteLine(arr1[i] * arr2[i]);             //WRITE A OUTPUT STATEMENT AND MULTIPLE THE TWO ARRAYS.
            }
        }
       
    }
}
