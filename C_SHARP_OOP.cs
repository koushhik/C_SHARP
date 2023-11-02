
```csharp
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_METHODS
{
    class program   
    {
        static void MethodCall()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("CALLING OF METHOD :");
        }

       
        static void SinglePara(string fname)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("THE SINGLE PARAMETER PASSED ON IS :" + fname);

        }
       
        
        static void DoublePara(string fname, int age)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("THE DOUBLE PARAMETER USED ARE NAME AND AGE : " + fname + "  " + age);
        }
       
        
        static void DefPara(string choc = "BOURNVILLE")
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("THE DEFAULT PARAMETER IS CALLED AT THIRD : " + choc);
        }


        static int RetVal(int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return x + y;
        }

        static void NamedArg(string CHILD1, string CHILD2, string CHILD3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("THE NAMED ARGUMENT EXAMPLE (jessy) : " + CHILD3);
        }

        static int OVERLOAD(int a, int b)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            return a + b;
        }

        static double OVERLOAD2(double w, double e)
        {
            return w + e;
           
        }




        static void Main(string[] args)
        {
    //CALLING OF METHOD ONCE AND MULTIPLE TIMES
            Console.WriteLine("THIS IS AN EXAMPLE FOR THE CALLING OF A METHOD ONCE :");
            MethodCall();
            Console.WriteLine("   ");
            Console.WriteLine("THIS IS AN EXAMPLE FOR THE CALLING OF A METHOD MULTIPLE TIMES :");
            MethodCall();
            MethodCall();
            MethodCall();
            Console.WriteLine("   ");
            Console.WriteLine("   ");
    //USING SINGLE PARAMETERS AND DOUBLE PARAMETERS
            SinglePara("JOHN");
            Console.WriteLine("   ");
            DoublePara("MONKEY D LUFFY", 23);
            Console.WriteLine("   ");
            Console.WriteLine("   ");
    //USING A DEFAULT PARAMETERS
            DefPara("TEMPTATIONS");
            DefPara("DIARY MILK SILK");
            DefPara();
            DefPara("PERK");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
    //NAMED ARGUMENTS WITH ASSIGNING TO NEW VALUE Z
            int z = RetVal(10, 20);
            Console.WriteLine("THIS IS AN EXAMPLE FOR RETURN VALUE WITH ASSIGNMENT TO NEW VARIABLE : " + z);
            Console.WriteLine("   ");
            Console.WriteLine("   ");
    //NAMED ARGUMENTS 
            NamedArg(CHILD1: "JOHN", CHILD2: "JENNY", CHILD3: "JESSY");
            Console.WriteLine("   ");
            Console.WriteLine("   ");
    //METHOD OVERLOADING 
            int p = OVERLOAD(10 , 20);
            double c = OVERLOAD2(10.1 , 20.4);
            Console.WriteLine("EXAMPLE FOR OVERLOADING FOR INT : " + p);
            Console.WriteLine("   ");
            Console.WriteLine("EXAMPLE FOR OVERLOADING FOR DOUBLE : " + c);
            Console.WriteLine("   ");
            Console.WriteLine("   ");
        }
    }

}
```
