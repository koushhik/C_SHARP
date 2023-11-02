```csharp

/C SHARP BASIC EXERCISES:

//3. Write a C# Sharp program to print the result of dividing two numbers.


using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            int x = 10;                                          //WE ASSIGN TWO VARIABLE OF INTEGER TYPE WITH TWO NUMBERS 10 AND 2
            int y = 2;
            int div = x / y;                                     //WE CREATE A INTEGER VARIABLE CALLED div TO STORE THE DIVIDED VALUE (X DIVIDE BY Y) WE USE '/' OPERATOR FOR DIVISION
            Console.WriteLine(div);                              //WE PRINT THE VALUE OF div WHICH CONTAINS THE DIVIED RESULT OF x and y.


            //additionall we can use input from users by using "READLINE" :
           
           /* 
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / b);
           */


        }
    }

}
```
