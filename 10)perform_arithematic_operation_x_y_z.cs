/*
        10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z
*/

using System; //here we use only one header , which is quite sufficient.

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());   //WE TEKE 3 NUMBERS X , Y AND Z AS INPUT FROM THE USERS
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((x + y)*z);                   //WE THEN PERFORM ARITHEMATIC OPERATIONS LIKE (X + Y)*Z
            Console.WriteLine((x*y) + (y * z));             //AND (X * Y) + (Y * Z)
        }
    }

}
