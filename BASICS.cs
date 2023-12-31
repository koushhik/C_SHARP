
```csharp
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewCSharp
{
    internal class Program
    {
        public static object Cosole { get; private set; }

        static void Main(string[] args)
        {
            //METHOD TO DISPLAY THE DTA IN THE TERMINAL
            Console.Write("hello guys..");                   
            Console.Write("how are you all.");                
            Console.WriteLine("hope you all are doing well :");
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.WriteLine("              ");




            //ASSIGNMENT OPERATOR IN C SHARP

            int pe = 5;
            pe += 3;
            int me = 10;
            me -= 6;
            int ie = 5;
            ie *= 3;
            int de = 5;
            de = 3;
            int re = 5;
            re %= 3;
            int ae = 5;
            ae &= 3;
            int se = 5;
            se |= 3;
            int ue = 5;
            ue ^= 3;
            int gge = 5;
            gge >>= 3;
            int lle = 5;
            lle <<= 3;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS ASSIGNMENT OPERATOR-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");




            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("THE ASSIGNMENT OPERATOR += (pe = pe + 3) DISPLAYS AS: " + pe);
            Console.WriteLine("THE ASSIGNMENT OPERATOR -= (me = me - 3) DISPLAYS AS: " + me);
            Console.WriteLine("THE ASSIGNMENT OPERATOR *= (ie = ie * 3) DISPLAYS AS: " + ie);
            Console.WriteLine("THE ASSIGNMENT OPERATOR /= (de = de / 3) DISPLAYS AS: " + de);
            Console.WriteLine("THE ASSIGNMENT OPERATOR %= (re = re % 3) DISPLAYS AS: " + re);
            Console.WriteLine("THE ASSIGNMENT OPERATOR &= (de = de & 3) DISPLAYS AS: " + ae);
            Console.WriteLine("THE ASSIGNMENT OPERATOR |= (se = se | 3) DISPLAYS AS: " + se);
            Console.WriteLine("THE ASSIGNMENT OPERATOR ^= (de = de ^ 3) DISPLAYS AS: " + ue);
            Console.WriteLine("THE ASSIGNMENT OPERATOR >>= (gge = gge >> 3) DISPLAYS AS: " + gge);
            Console.WriteLine("THE ASSIGNMENT OPERATOR <<= (lle = lle << 3) DISPLAYS AS: " + de);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            //COMPARISON OPERATORS IN C SHARP
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS COMPARISION OPERATOR SEGMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            int zz = 5;
            int yy = 3;
            Console.WriteLine(zz == yy); //EQUAL TO
            Console.WriteLine(zz != yy); //NOT EQUAL TO
            Console.WriteLine(zz > yy);  //GREATER THAN
            Console.WriteLine(zz < yy);  //LESSER THAN
            Console.WriteLine(zz >= yy); //GREATER THAN OR EQUAL TO
            Console.WriteLine(zz <= yy);  //LESSER THAN OR EQUAL TO
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            //LOGICAL OPERATORS IN C SHARP
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS LOGICAL OPERATOR SEGMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int lo = 5;
            Console.WriteLine(lo > 3 && lo < 10); //AND operator returns TRUE if both values are true
            Console.WriteLine(lo > 3 || lo < 3); //OR operator returns TRUE if one of the value is true
            Console.WriteLine(!(lo > 3 && lo < 10)); //LOGICAL NOT this is used to negate value from True to False
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.White;

            //MATHEMATICAL METHODS C SHARP
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS MATHEMATICAL VALUE SEGMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Math.Max(5, 3));    //RETURNs MAXIMUM OF TWO NUMBERS
            Console.WriteLine("              ");
            Console.WriteLine(Math.Min(5, 3));    //RETURNS MINIMUM OF TWO NUMBERS
            Console.WriteLine("              ");
            Console.WriteLine(Math.Sqrt(64));     //RETURNS THE SQUARE ROOT VALUE OF THE NUMEBR
            Console.WriteLine("              ");
            Console.WriteLine(Math.Abs(-98));     //RETURNS THE ABSOLUTE POSITIVE VALUE OF A NUMBER
            Console.WriteLine("              ");
            Console.WriteLine(Math.Round(56.54)); //ROUNDS THE NUMBER INTO THE NEAREST INTEGER
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.White;


// STRING OPERATIONS IN C SHARP
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS STRING OPERATIONS SEGMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");

            //STRINGS IN C SHARP
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("THIS DENOTES THE BASIC STRING INTRODUCTION AND FUNCTIONs");
            Console.WriteLine("              ");
            string greeting = "Hello guys";
            Console.WriteLine(greeting); //This shows that string displays the collection of characters
            Console.WriteLine("              ");
            string greetings = ("HELLO EVERYONE HOW ARE YOU ALL DOING HOPEE YOU ALL ARE FINE ...!!");
            Console.WriteLine(greetings);
            //The above line indicates that string isnt just restricted to one word but rather can print whole sets
            //because string assigns 2 bits for every character so it can expant the length
            Console.WriteLine("              ");
            string vvv = "hello guys";
            Console.WriteLine("THe length of the string 'hello guys' is :" + vvv.Length); //This hows the length of the string
            Console.WriteLine("              ");
            string well = "HeLlO GuYs";
            Console.WriteLine("CONVERTING THE STRING'HeLlO GuYs' TO UPPER CASE :" + well.ToUpper()); //this converts string to uppercase
            Console.WriteLine("              ");
            Console.WriteLine("CONVERTING THE STRING 'HeLlO GuYs' TO LOWER CASE :" + well.ToLower()); //this converts string to lower case

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");

            //STRING CONCATENATION IN C SHARP
            Console.ForegroundColor = ConsoleColor.Magenta;
               //WE CAN USE PLUS OPERATOR TO CONCATENATE TWO STRINGS 
            string str1 = "ADDITION ";
            string str2 = "CONCATENATION";
            string dede = str1 + str2;
            Console.WriteLine(dede);
            Console.WriteLine("              ");
                //WE CAN ALSO USE AN INBUILT FUNCTION TO CONCATENATE TWO STRINGS
            string fff = "IN BUILT FUNCTION ";
            string ggg = "CONCATENATION";
            string hhh = string.Concat(fff, ggg);
            Console.WriteLine(hhh);
            Console.WriteLine("              ");
            //ADDING NUMBERS AND STRING if you add TWO NUMBERS THE RESULT WILL BE A NUMBER
            int qqq = 10;
            int www = 20;
            Console.WriteLine("ADDING TWO NUMBERS GIVES A NUMBER  :" + qqq + www);
            Console.WriteLine("              ");
           string ttt = "30";
            string nnn = "40"; // A STRING WILL ALWAYS HAVE DOUBLE QUOTES
            Console.WriteLine("ADDING TWO STRING GIVES A NUMBER IVEN IF IT LOOKS LIKE A NUMBER IT IS A STRING :" + (ttt + nnn));
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            //STRING INTERPOLATION $$$$
            string baba = "INTERPOLATION";
                string cab = " EXAMPLE";
            string naam = $"the message is :{baba}{cab}";
            Console.WriteLine(naam);
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            //STRING ACCESS METHODS
            // WE CAN ACCESS PARTICULAR STRING UUSING INDEX [ POSITION NUMBER ] POS starts fom O 
            string sss = "hello all";
            Console.WriteLine(sss[6]); //here we use [] for accesing elements using the index number
            Console.WriteLine("              ");
            //we use inbuilt function IndexOf to access the position of element 
            Console.WriteLine(sss.IndexOf("e"));
            Console.WriteLine("              ");
            //We can use IndexOf and Substring functios to access whole word rather than 1 character
            int charpos = sss.IndexOf("a");
            string lnaam = sss.Substring(charpos);
            Console.WriteLine(lnaam);

            Console.WriteLine("              ");
            Console.WriteLine("              ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");

 //BOOLEAN VALUES
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS BOOLEAN VALUE STATEMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            bool rex = true;
            bool tex = false;
            Console.WriteLine(rex);                //Displays Value as true
            Console.WriteLine("              ");
            Console.WriteLine(tex);                //Displays value as false
            Console.WriteLine("              ");
            int zaza = 10;
            int giza = 30;
            Console.WriteLine(zaza > giza);       //here two integer is compared using comparision operator, but the result will be boolean
            Console.WriteLine("              ");
            //Easier way of comparision
            Console.WriteLine(10 > 2);
            Console.WriteLine("              ");
            //Comparision using comparission operator to check == equivalency 
            int vc = 10;
            Console.WriteLine(vc == 10);
            //Easier way of using comparision operator 
            Console.WriteLine("              ");
            Console.WriteLine(10 == 20);
            Console.WriteLine("              ");

            //REAL LIFE EXAMPLE
            
            int Vage = 18;
            int myAge = 23;
            Console.WriteLine(myAge >= Vage);
            Console.WriteLine("              ");
            Console.WriteLine("              ");

            int MyAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("              ");
            if (MyAge >= Vage)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("OLD ENOUGH TO VOTE...!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NOT OLD ENOUGH TO VOTE..!");
            }





            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


 //IF STATEMENT
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS IF STATEMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Blue;
            

            //IF STATEMENT WITH VAR DECLAIRED
            int sad = 10;
            int dad = 20;
            if (sad < dad)
            {
                Console.WriteLine("10 IS INDEED LESS THEN 20");
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");
 // ELSE STATEMENT
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS ELSE STATEMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Magenta;

            int time = 6;
            if (time < 6)
            {
                Console.WriteLine("CONTINUE TO WORK");
            }
            else
            {
                Console.WriteLine("GO HOME...!!");
            }
            Console.WriteLine("              ");

//ELSE IF STATEMENT
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS ELSE STATEMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int Tme = 33;
            if (Tme < 20)
            {
                Console.WriteLine("NOT YET");
            }
            else if (Tme < 30)
            {
                Console.WriteLine("STILL NOT YET");
            }
            else
            {
                Console.WriteLine("ITS TIME....!!");
            }



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


 //SHORT HAND IF ELSE STATEMENT


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT SHORT HAND IF STATEMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Red;
            int mmt = 33;
            string final = (mmt > 10) ? "good morning" : "good evening";
            Console.WriteLine(final);
            


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");



            //SWITCH STATEMENT
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT SWITCH CASE STATEMENT-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            int book = 3;
            switch (book)
            {
                case 1: Console.WriteLine("SCARE CROW");
                    break;
                case 2: Console.WriteLine("ANGELS AND DEAMONS");
                    break;
                case 3: Console.WriteLine("REVOLUTION 20-20");
                    break;
                case 4: Console.WriteLine("moon walking with Einstein");
                    break;

            }

            Console.WriteLine("              ");

            int bok = 44;
            switch (bok)
            {
                case 1:
                    Console.WriteLine("SCARE CROW");
                    break;
                case 2:
                    Console.WriteLine("ANGELS AND DEAMONS");
                    break;
                case 3:
                    Console.WriteLine("REVOLUTION 20-20");
                    break;
                case 4:
                    Console.WriteLine("moon walking with Einstein");
                    break;
                default: Console.WriteLine("NO SUCH BOOK HAS BEEN FOUND");
                    break;

            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");






            // <--------------------@@@------------------------>
            // <-------------------@@@@@----------------------->
            // <------------------@@@@@@@---------------------->
            // <------------------@=====@---------------------->
            // <-------------------@===@----------------------->








            
            //WHILE LOOP


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT WHILE LOOP-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Blue;

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("              ");

            //HOW DOES WHILE LOOP WORKS ...? 
            /*
             * first when a variable is created an initial value is set to it ...Generall 0
             * in While loop a condition is checked using conditional operators such as >,< >=,<= etc.
             * inside the loop a statement is given which needs to be printed mmultiple times ...
             * that is until that particular condition doesnt get satisified....
             * the last line is used to increment the initialized value useed incremnt operator which increses the value until condition gets satisified
             * when the condition infact gets satisified then the...while loop stops ...and so does the output
             * WHILE LOOP IS IDEL TO PRINT MULTIPLE OUTPUT FOR A CONDITION WITHOUT USING LARGE CHUNKS OF CODE;
             */


            int ii = 0;
            do 
            {
                Console.WriteLine(ii);
                ii++;
            } while (ii > 7);
           
            //in the do while loop the output gets printed same as while loop when condition is true
            //but unlike while loop in do while loop the condition gets printed once even if the condition is false 
            //tHIS IS BECAUSE THE CONDITION IS GETTING CHECKED AT HE END AND BEFORE THAT PRINT STATEMENT IS ALREADY IS IN ITS PLACE 



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");







            //copy
            //WHILE LOOP


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS OF FOR LOOP-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //In the case of while loop you do not know generally how many ties you wanna loop
            //but if you do know or want this many times to be looped WE USE FOR LOOP
            //GENERAL SYNTAX IS AS FOLLOWS:
            //for (Statement 1; statement 2; statement 3)
            //STATEMENT-1 : WILL BE EXECUTED ONE TIME BEFORE THE EXECUTION OF THE CODE BLOCK;
            //STATEMENT-2 : THIS SEGMENT DEFINES THE CONDITION FOR THE EXECUTION OF THE CODE ;
            //STATEMENT-3 : THIS SEGMENT IS EXECUTED AFTER THE CODE BLOCK HAS BEEN EXECUTED 

            
            for (int iii = 0; iii < 7; iii++)
            {
                Console.WriteLine("print me this times : " + iii);
            }


            Console.WriteLine("              ");
            //For printing Even Positive numbers the code goes as follows 

            for (int ep = 0; ep < 10; ep += 2)
            {
                Console.WriteLine("Even Positive Numbers Are :" + ep);
            }

            Console.WriteLine("              ");

            //It is also possible to add for loop inside a for loop which we generally call as :
            //NESTED LOOP


            /* ????CODE TO BE INCLUDED???? */




            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");














            //For Each LOOP

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS OF FOR LOOP-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Cyan;

            //FOR EACH LOOP IS SPECIFICALLY USED TO LOOP THROUGH THE LEMENT IN AN ARRAY 
            // SYNATX :
            //for (type variablename in arrayname)
            //     {
            //  //code block to be executed//
            //     }

            //Consider an array of strings 

            string[] cars = { "FERRARI", "MASERATTI", "ASTON MARTIN", "PORCHE" };
            foreach (string iz in cars)
                {
                Console.WriteLine(iz);
            }
            

            



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");









            //BREAK AND CONTINUE STATEMENTS 

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS OF FOR LOOP-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Magenta;

            //Break statement is used to come out or lets say jump out of the loop

            for (int iu = 0; iu < 10; iu++)
            {
                if (iu == 4)
                {
                    break;
                }
                Console.WriteLine(" FOR VALUE 4 BREAK STATEMENT IS APPLIED :" + iu);

            }

            Console.WriteLine(" --------------         -------------");

            //Simlarly we can usde continiue statement to resume the loop

            for (int ik = 0; ik < 10; ik++)
            {
                if (ik == 5)
                {
                    continue;
                }
                Console.WriteLine("THE CONTINUE STATEMENT RESUME UPON IK == :" + ik);
            }


            //We can use BREAK AND CONTINUE FOR THE WHILE LOOPS AS WELL
            Console.WriteLine(" --------------         -------------");
            Console.WriteLine("                ");
            Console.WriteLine(" --------------         -------------");
            int io = 0;
            while (io < 5)
            {
                if (io == 3)
                {

                    break;
                }
                Console.WriteLine("Break is Intanstiaited when the value is equal to 3: " + io);
                io++;
            }

            //WE CAN USE THE CONTINUE FOR THE WHILE LOOP AS WELL
            Console.WriteLine(" --------------         -------------");

            int ij = 0;
            while (ij < 10)
            {
                if (ij == 4)
                {
                    ij++;
                    continue;
                }
                Console.WriteLine("THE CONTINUE STATEMENT IS EXECUTED WHEN THE VALUE IS 2 :" + ij);
                ij++;
            }




            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");





















            //ARRAYS IN C SHARP

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@@@@@@@-----------------THIS SEGMENT IS OF FOR ARRAY IN C SHARP-------------------@@@@@@@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Red;


            //TO STORE MULTIPE VALUES IN A SINGLE VARIABLE WE USE ARRAYS INSTEAD OF DECLAIRING SEPERATE VARIABLES FOR EACH VALUES.
            //we generally use square brackets to define variable type.
            
            //--------------DECLAIRING AN ARRAY--------------//
            string[] motor;
            int[] andy;

            //--------------ADDING ELEMENTS IN AN ARRAY-----------------//
            string[] fruits = { "apple", "mango", "kiwi", "guava" };
            int[] even = {2, 4, 6, 8};       //for int no need double quotes

            //--------------ACCESSING THE ELEMENTS OF AN ARRAY-----------//
            string[] chock = { "KIT-KAT","BOURNVILLE","SILK","TEMPTATIONS"};
            Console.WriteLine("FOR ACESSING AN ELEMENT IN AN ARRAY : " + chock[1]);

            Console.WriteLine(" (@)=(@)                                <==----------------------------------<<<<                     --# ");

            //---------------ARRAY LENGTH---------------------//
            int[] eve = { 2, 4, 6, 8, 10 };
            Console.WriteLine("PRINTING THE SIZE OF AN ARRAY :" + eve.Length);


            //-------------------other ways to create an array--------------//
            //#1 - create an array BUT ADD VALUES LATER - //
            int[] odd = new int[6];
            string[] bikes = new string[6];

            //#2 - Create an array then ADD VALUE RIGHT AWAY - //
            int[] evei = new int[5] { 12, 14, 16, 18, 20 };
            string[] rer = new string[3] { "dodo", "dino", "titano boa" };

            //#3 - Create an array without specifiying the size -//
            int[] nos = new int[] { 2, 4, 5, 6, 3 };
            string[] anime = new string[] { "tokyo ghouls", "naruto", "monster", "midori", "ONE PIECE" };

            //#4 - create an array omitting the NEW keyword and WITHOUT SPECIFING THE SIZE
            string[] shapes = { "cirlce", "square", "rectangle", "elipse" };
            //#4 is the best method easy and friendly //

            //#4 but in this method if you DECLAIR AN ARRY AND INITIALIZE IT LATER WE WILL HAVE TO USE THE NEW KEYWORD

            //FOR EXAMPLE :

            Console.WriteLine(" (@)=(@)                                <==----------------FOR LOOP EXAMPLE------------------<<<<                     --# ");
            {
                string[] JKJ = { "SATYA NADELLA", "STEVE JOBS", "SUNDAR PICHAI" };
                for (int mm = 0; mm < JKJ.Length; mm++)
                {
                    Console.WriteLine(cars[mm]);
                }
            }



            //LAG JAA GALE KE ...HE ...HE ....





            //ACCESSING ARRAYS USING THE FOR EACH LOOPS 

            string[] deck = { "spade", "diamond", "club", "heart" };
            foreach (string ikk in deck)
            {
                Console.WriteLine(ikk);
            }


            //SORTING OF ELEMENTS IN AN ARRAY FOR INTEGER
            Console.WriteLine(" (@)=(@)                                >>>>------------------SORTING AN INTEGER----------------=*=>                   --# ");
            // in this example we use inbulit function declaired as : Array.Sort(array name);
            int[] axin = { 4, 6, 7, 8, 10, 1 ,2,3,5,6,9 };
            Array.Sort(axin);
            foreach (int opi in axin)
            {
                Console.WriteLine(opi);
            }

            //SORTING OF ELEMENTS IN AN ARRAY FOR STRING
            Console.WriteLine(" (@)=(@)                                <==--------------SORTING A STRING--------------------<<<<                     --# ");
            string[] NEWTON = { "CAB", "ADAM", "BELIAL", "DRACULE" };
            Array.Sort(NEWTON);
            foreach (string iyy in NEWTON)
            {
                Console.WriteLine("THIS IS THE SORTED ARRAY FOR A STRING   :" + iyy );
            }


            //THIS IS FOR UNISG INBUILT FUNCTION TO DO OPERATIONS IN AN ARRAY USING THE LINQ HEADERFILES
            Console.WriteLine(" (@)=(@)                                <==----------------OPERATIONS ON ARRAY------------------<<<<                     --# ");
            int[] huh = { 2, 5, 6, 7, 8, 9, 10, 1, 2, };
            {
                Console.WriteLine(huh.Sum());
                Console.WriteLine(huh.Max());
                Console.WriteLine(huh.Min());
            }

















            //COMPLEX OPERATION USING MULTI-DIMENTIONAL ARRAY




            //MANA KE HUM YAAR NHI 
            //LO TEY HAI KI PYAR NAHI
            //MAQANA KE HUM YAAR NHI 
            //LO TEY HAI KE PYAR NHI 




            //PHIR BHI NAZREN N AMILO NA



            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("<-@-----------------THIS SEGMENT IS FOR MULTI DIMENTIONAL ARRAYS-------------------@->");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("              ");
            Console.ForegroundColor = ConsoleColor.Blue;

            //LOOPING THROUGH THE ELEMENTS IN THE MULTI DIMENTIONAL ARRAY
            Console.WriteLine("              ");
            Console.WriteLine("              ");
            int[,] ikl = { { 1, 2, 3 } , { 4, 5, 6 } };
            foreach (int jha in ikl)
            {
                Console.WriteLine(jha);
            }

            Console.WriteLine("              ");

            //FOR CHANGING THE ELEMENT IN A MULTI DIMENTIONAL ARRAY
            int[,] jki = { {8, 7, 9 }, {6, 5, 3} };
            jki[0, 2] = 5;
            foreach (int ihj in jki)
            {
                Console.WriteLine(ihj);
            }

            //FOR LOOPING THROUGH ALL THE ELEMNTS IN THE MULTI DIMENTIONAL ARRAY USING THE FOR LOOP

            Console.WriteLine("              ");

            int[,] bvc = { {1, 2, 3 }, {3, 2, 1 } };
            {
                for (int df = 0; df < bvc.GetLength(0); df++)
                {
                    for (int fd = 0; fd < bvc.GetLength(1); fd++)
                    {
                        Console.WriteLine(" Multi DIMENTIONAL ARRAY USING FOR LOOP IS AS FOLLOWS :" + bvc[df, fd]);
                    }
                }
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("              ");
            Console.WriteLine("              ");











































            //<-------------@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@-------------->//

            //proper data types in C sharp//

            /* INT = 4 BYTES */
            int a = 2147483647; //max limit for the integer data type is -2,147,483,648 TO 2,147,483,647
                                   //TO strore very long integer beyond lets say +2 billion to -2 billion we use data type long 
                                   //long allows storage of whole number till 9 sextillion which is 9,000,000,000,000,000,000 both in + and - side;
            /* LONG = 8 BYTES */
            long aa = 9223372036854775807L;

            //long goes 9 sextillion but if you want to push more you go for u long which is 18 sextillion 18^18;
            /* ULONG = 8 BYTES */
            ulong aaa = 18446744073709551615U;
            /*FLOAT = 4 BYTES*/
                   //float numbers can also be a scientific number considering that using e and E to show the power of 10 
            float bb = 7.76F;
            float bbb = 7e3F;
            /* DOUBLE = 8 BYTES */
            double b = 1.22D;                   //this data type can store upto 15 decimal numbers 
            /* 2 BYTES */
            char c = 'z';      
            /* 2 BYTES per character */
            string d = "attention";
            /* 1 Bit */
            bool e = true;




            // C sharp type conversion : there are 3 main methods for the type conversion
            // IMPLICIT CONVERSION (automatically) smaller type to larger type
            // EXPLICIT CONVERSION (manually) larger type into smaller type
            // BUILT IN  

            //EXAMPLE FOR IMPLICIT CONVERSION:
            int im = 10;
            double imm = im;
            Console.WriteLine("THIS IS AN EXAMPLE FOR THE IMPLICIT TYPE CONVERSION :");
            Console.WriteLine("THE INTEGER DATA TYPE TO BE CASTED      :" + im);
            Console.WriteLine("THE INTEGER DATA TYPE CONVERTED INTO FLOAT     :" + imm); ;
            Console.WriteLine(" -@-@-@-@-@-@-@-");
            Console.WriteLine("         ");
            Console.WriteLine("         ");
            Console.WriteLine("         ");

            //EXAMPLE FOR TH EXPLICIT CONVERSION 
            double doub = 2.89D;
            int mint = (int) doub;
            Console.WriteLine("THIS IS AN EXAMPLE FOR THE IMPLICIT TYPE CONVERSION :");
            Console.WriteLine("THE DOUBLE DATA TYPE TO BE CASTED: " + doub);
            Console.WriteLine("THE DOUBLE DATA TYPE CONVERTED TO INT  : " + mint);
            Console.WriteLine(" -@-@-@-@-@-@-@-");
            Console.WriteLine("         ");
            Console.WriteLine("         ");
            Console.WriteLine("         ");

            //EXAMPLE FOR THE BUILT IN METHOD OF CONVERSION
            int w = 20;
            double x = 15.26;
            bool y = false;
            Console.WriteLine("THIS IS AN EXAMPLE FOR THE BUILT IN CONVERSION :");
            Console.WriteLine("         ");
            Console.WriteLine("THE BUILT IN METHOD TO CONVERT INT TO STRING");
            Console.WriteLine(Convert.ToString(w));
            Console.WriteLine("         ");
            Console.WriteLine("THE BUILT IN METHOD TO CONVERT INT TO DOUBLE");
            Console.WriteLine(Convert.ToDouble(w));
            Console.WriteLine("         ");
            Console.WriteLine("THE BUILT IN METHOD TO CONVERT DOUBLE TO INT");
            Console.WriteLine(Convert.ToInt32(x));
            Console.WriteLine("         ");
            Console.WriteLine("THE BUILT IN METHOD TO CONVERT BOOL TO STRING");
            Console.WriteLine(Convert.ToString(y));
            Console.WriteLine("         ");
            Console.WriteLine("         ");
            Console.WriteLine("         ");


            //METHOD TO TAKE INPUT INSTRUCTION FROM USERS USING THE READLINE()

            //this method is used only for string operation on readline()
            /* int zzz = Console.ReadLine();int*/
            //to read int inputs one needs to do type conversions , preferably built in conversions
            int j = 10 + 20;
            int sum1 = j + 300;
            int sum2 = sum1 + j;
            int add = 10 + 10;
            int sub = 20 - 10;
            int mul = 20 * 10;
            int div = 40 / 10;
            int mod = 40 % 10;
            int inc = 2000;
            inc++;
            int dec = 2000;
            dec--;

            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(mul);
            Console.WriteLine(div);
            Console.WriteLine(mod);
            Console.WriteLine(dec);
            Console.WriteLine(inc);

      
            
            


            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("THe OUtput of the addition is as follows :" + "  " + sum2 + "   " + sum1 + "    " + j);
            Console.WriteLine("        ");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  ENTER YOUR AGE:");
            
            int zzz = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("         ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  ENTER YOUR USER NAME: ");
            string usr = Console.ReadLine();

            Console.WriteLine("         ");
            Console.WriteLine("         ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("<<@<<@<<@<@@<@@@<-----YOUR USERNAME IS :" + usr + "----->@@@>@@>@@>@>>");
            Console.WriteLine("<<@<<@<<@<@@<@@@<-----YOUR AGE IS      :" + zzz + "----->@@@>@@>@@>@>>");

            Console.WriteLine("         ");
            Console.WriteLine("         ");


            Console.WriteLine("   ENTER YOUR PASSWORD:");
            Console.ForegroundColor = ConsoleColor.Black;
            string UN = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            string TD = "koushik";
            if(UN == TD) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("       <CORRECT PASSWORD...!>       ");
                Console.WriteLine("         ");
                Console.WriteLine("         ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("        YOUR PASSWORD (REVEAL) :" + UN);
                Console.WriteLine("        <wrong password exiting in 3 sec>");
                Console.WriteLine("         ");
                Console.WriteLine("         ");
            }

            //IS THERE A POSITION IIN BANGALORE SIR ...
            //DEHK KE MUJHE KYUN TUM DEKHTE NAHI ...YAARA AISI BERUKI SAHI TOH NAHI ...
            //DEHKO GOR SE KAHI KI MEIN VAHI TOH NHI
            //TUMHE PYAR SE PYAR HONE LAGEGA ...MSERE SAATH SHAME TO
            //MAHABBAT KI RAH HON MEIN AA KAR TOH DEKHO ..
            //DIL KI SUNU ISHQ KHAI KI DILLLAGI KE NHI ...



           

            //THE WHOLE NUMBER FAMILY DATA TYPES
            Console.WriteLine("This is an Integer data type :" + a);
            Console.WriteLine("This is a long data type :" + aa);
            Console.WriteLine("This is an ulong data type :" + aaa);
            Console.WriteLine("         ");
            Console.WriteLine("         ");

            //THE DECIMAL FAMILY DATA TYPES
            Console.WriteLine("This is a float data type :" + b);
            Console.WriteLine("This is a float with scjientific notation :" + bbb);
            Console.WriteLine("This is a double data type :" + bb);
            Console.WriteLine("         ");
            Console.WriteLine("         ");

            //THE ALPHABET FAMILY
            Console.WriteLine("This is a character data type :" + c);
            Console.WriteLine("This is a string data type :" + d);
            Console.WriteLine("         ");
            Console.WriteLine("         ");

            //THE BOOLEAN FAMILY
            Console.WriteLine("This ia boolean data type :" + e);
            Console.WriteLine("         ");
            Console.WriteLine("         ");


            //METHOD ARE USED QUITE IMPORTANTLY IN THEB C SHARP PLATFORm
            //FUNCTIONS ARE VERY LESS USED
            //METHODS AND OOP CONCEPTS ARE YET TO BE LEARNED FOR THS EPISODE OF C#
            //TUMHE DIL LAGGGI BOL JAAANI PADEGI ...KABHI DIL KISI SE LAGA KAR KE TOH DEKHO ....TUHMHE DIL LAGI BOOL JANI PADEGI
            //TUMHARE KHAYALONKI DUNIYA YAHI HAI 
            //ZARA MERI BAHON MEI ...AA KAE KE DEKHO 
            //MAHBAAT KI RAH HON MEIN AA KAR KE DEKHO
            Console.WriteLine(" hello world ");
            //HUMKO MILI HAI AAJ HAI YE GHADIYA NASEEB SE 
            //JEE BHAR KE DEKH LE YEH JIYE 
            //HUMKO KHAREEEB SE
            //PHIR AA[P KE NASSEB MEIN YEH BAAT HO NA HOO
            //SHAYAD PHIR ISS JANAM MEIN MULAQAT HO NA HO ..

            //
        //ABHI NA JAO CHOD KAR 
        //KE DIL ABHI BARA NAHI 
        //ABHI ABHI TOH AYE HO ...ABHI ABHI TOH ...
        //ABHI ABHI TOH AYE HO
                //BAHAR BAN KE CHAYE HO 
                //HAWA ZARA MEHEK TOH LE 
                //NAZAR ZARA BEHEK TOH LE
                //YE SHAM DHAL TO LE ZARA 
                //YEH DIL SAMHAL TO LE ZARA
                //MEIN TODII DER ZEE TOH LU
                //NASHE KI GHOT PEE TOH LU
                //ABHI TOH KUCH KAHA NAHI 
                //ABHI TOH KUCH SUNA NAHI///

        
        
        }
    }
}

```

