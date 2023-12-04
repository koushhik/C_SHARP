//This FILE or rather Program contains all the CRUD functions , with looping options after every operation perfomed , it contains CREATE, READ, UPDATE , DELETE , other operatuions based on ID or Name, Option to exit the terminal
//Visually appealing color choice , vibrant end of block graphics.
//\___(*_0)__?
global using global:System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Data;
using System.Xml.Serialization;

namespace EmpList
{
    public class Employee                                          //CREATING A CLASS TO ACCESS ALL THE VARIABLES THROUGH OUT THE PROGRAM CLASS 
    {
        public   int      ID       { get; set; }                   //DECLAIRING EACH VARIABLESS AS PUBLIC FOR ACCESS THROUGHOUT THE PROGRAM 
        public   string   Name     { get; set; }                   //GIVING CORRESPONDING DATA TYPES FOR THE VARIABLES 
        public   DateTime DOB      { get; set; }                   //THE DATA TYPE DateTime CAN HOLD DATE BUT IT ALSO HOLDS TIME AS WELL, WE CAN USE DateOnly TYPE
        public   int      Salary   { get; set; }
    }

    public class Program                                          //CREATING THE PROGRAM CLASS
    {
        static List<Employee> employees = new List<Employee>();   //CREATING A LIST WHICH IS A REFERNCE TO THE Employee CLASS ITS INSTANCE BEING employees
//OPTIONS==========================================================================================================================================================================================
        public void Options()                                     //CREATING OPTIONS METHOD TO TAKE COMMAND FROM USERS 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n|============================EMPLOYEE DATA OPTIONS=====================|");  //PRE WRITTEN MENU OPTIONS
            Console.WriteLine("\t1)-ADDING EMPLOYEE DETAILS");
            Console.WriteLine("\t2)-REMOVING EMPLOYEE DETAILS");
            Console.WriteLine("\t3)- SELECT EMPLOYEE DETAILS BY ID");
            Console.WriteLine("\t4)- SELECT EMPLOYEE DETAILS BY NAME");
            Console.WriteLine("\t5)-UPDATE EMPLOYEE DETAILS BY NAME");
            Console.WriteLine("\t6)-EXIT THE TERMINAL");
            Console.WriteLine("|======================================================================|\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|======================================================================|");
            Console.WriteLine("CHOOSE YOUR OPTIONS HERE:");                                                   //ASKING USERS CHOICE 
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|======================================================================|");


            if      (key == 1) { AddEmployee();          }                                                    //CREATING METHOD CALLING BASED ON USER CHOICES
            else if (key == 2) { RemoveEmployee();       }
            else if (key == 3) { SelectEmployeeById();   }
            else if (key == 4) { SelectEmployeeByName(); }
            else if (key == 5) { UpdateEmployee();       }
            else if (key == 6) { Exit();                 }
            else               { Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("|--W-R-O-N-G  O-P-T-I-O-N-S--|"); Console.ForegroundColor = ConsoleColor.White; Options(); }

        }
//FIND-ID==========================================================================================================================================================================================
//[HTTP GET-VERIFY]
        public Employee FindId(int ID)                 //METHOD TO CHECK IF THE GIVEN ID ACTUALLY CONTAINS IN THE LIST OR NOT ..!
        {
            for (int i = 0; i < employees.Count; i++)  //CREATING A LOOP TO TEST IF THE GIVEN ELEMENT MATCHES WITH THE INDEX OF LIST CONTENT
            {
                Employee emp = employees[i];           //TRAVERSING THROUGH THE LIST USING ARRAY 

                if (emp.ID == ID)                      //COMPARING THE GIVEN ELEMENT WITH THE LIST 
                {
                    return emp;                        //IF TRUE RETURNS emp WHICH CONTAINS ALL THE EMPLOYEE DETAILS 
                }
            }

            return null;                               //IF NOT FOUND RETURNS NULL, MEANING EMPLOYEE NOT FOUND IN THE LIST
        }
//EMPLOYEE-LIST==========================================================================================================================================================================================
        public List<Employee> EmployeeList(string EmpNme, int CHOICE)          //CREATING A METHOD OF TYPE LIST WITH INPUT VALUES OF TYPE string AND int
        {
            List<Employee> TempList = new List<Employee>();                    //WE CREATE A LIST TO STORE ALL THE DATA THAT EIGTHER STARTS WITH GIVEN DATA OR CONTAINS 

            if (CHOICE == 1 || CHOICE == 2)                                    //WE PERFORM OPERATIONS BESED ON USER CHOICE IF 1)THEN TEST STARTS WITH CONDITION.
            {
                for (int i = 0; i < employees.Count; i++)                      //WE TRAVERSE THE LIST TO FIND IF USER GIVEN NAME IS PRESENT IN LIST OR NOT 
                {
                    Employee emp = employees[i];                               //ARRAY THAT TRAVERSES THE LIST BASED ON INDEX VALUE 

                    if (CHOICE == 1 && emp.Name.StartsWith(EmpNme))            //TESTING OUT THE STARTS WITH CONDITION 
                    {
                        TempList.Add(emp);                                     //IF TRUE THEN THE EMLOYEE DETAILS WILL BE ADDED TO THE NEW LIST TempList
                    }
                    else if (CHOICE == 2 && emp.Name.Contains(EmpNme))         // CHECKING IF GIVEN NAME HAS WORDS THAT ARE CONTAINED IN MAIN LIST
                    {
                        TempList.Add(emp);                                     //IF YES THEN ALL SUCH DTA ARE ADDED TO THE NEW LIST
                    }
                }
                return TempList;                                               //AFTER ALL THE LIST IS CHECKED THEN WE RETURN THE LIST TO THE CALLING METHOD FOR FUTHER WORK

            }
            else { return null; }                                              //IF NONE OF CHOICES ARE ENTERED WE RETURN NULL.

        }
//ADD-EMPLOYEE==========================================================================================================================================================================================
       //[HTTP GET]
        public void AddEmployee()
        {
            Employee emp = new Employee();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<ADD EMPLOYEE DETAILS>-----------|");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nENTER YOUR ID :");                         //ENTERING YOUR NEW ID TO THE LIST 
            emp.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nENTER YOUR NAME :");                       //ENTERING YOUR NEW NAME TO THE LIST
            emp.Name = Console.ReadLine();

            Console.WriteLine("\nENTER YOUR DATE OF BITH");                 //ENTERING YOUR NEW D.O.B TO THE LIST
            emp.DOB = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nENTER YOUR SALARY");                       //ENTERING YOUR NEW SALARY TO THE LIST
            emp.Salary = Convert.ToInt32(Console.ReadLine());

            employees.Add(emp);                                             //INBUILT FUNCTION TO ADD EMPLOYEES TO THE LIST.

            Options();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }
//REMOVE-EMPLOYEE==========================================================================================================================================================================================
        //[HTTP-REMOVE]
        public void RemoveEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<REMOVE EMPLOYEE DETAILS>-----------|");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nENTER THE ID OF THE EMPLOYEE EHICH NEEDS TO BE REMOVED :");        //ENTERING THE ID OF THE EMPLOYEE TO BE REMOVED
            int ID = Convert.ToInt32(Console.ReadLine());

            Employee x = FindId(ID);                      //PASSING ID AS THE PARAMETER, AND STORING THE RESULT AFTER RETURN VALUE IN x.

            if (x != null) { Console.WriteLine("\nEMPLOYEE LIST FOUND REMOVING " + x.ID + " --DONE SUCCESSFULLY"); employees.Remove(x); Options(); }  //INBUILT REMOVE FUNCTION.
            else { Console.WriteLine("\n|--- LIST NOT FOUND IN THE TABLE (try again.!)---|"); Options(); }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
 //SELECT-EMPLOYEE-BY-ID==========================================================================================================================================================================================
       //[HTTP GET {ID}]
        public void SelectEmployeeById()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<SELECT EMPLOYEE DETAILS BY ID>-----------|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nENTER THE ID OF THE EMPLOYEE EHICH NEEDS TO BE SELECTED :");         //ENTERING ID THROUGH WICH EMPLOYEE DETAILS ARE ACCESSED
            int ID = Convert.ToInt32(Console.ReadLine());

            Employee y = FindId(ID);                               //PASSING ID AS PARAMETER AND STORING THE RETURN VALUES IN Y

            Console.ForegroundColor = ConsoleColor.Green;
            if (y != null) { Console.WriteLine("\t|-- " + y.ID + "\t" + y.Name + "\t" + y.DOB + "\t" + y.Salary + " --|"); Options(); }
            else { Console.WriteLine("\nWRONG ID PLEASE TRY AGAIN ...!!"); Options(); }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
//SELECT-EMPLOYEE-BY-NAME==========================================================================================================================================================================================(*)>
        //[HTTP-SELECT-BY NAME]
        public void SelectEmployeeByName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<SELECT EMPLOYEE DETAILS BY NAME>-----------|\n");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\n ENTER OPTION FROM THE FOLLOWING : \n\n \t 1)-CHECK IF THE LIST HAS NAMES STARTING WITH \n \t 2)-CHECK THE LIST CONTAINS THE ELEMENT \n");
            int CHOICE = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nENTER THE NAME OF THE EMPLOYEE EHICH NEEDS TO BE SELECTED :");
            string EmpName = Console.ReadLine();

            List<Employee> EmpList = EmployeeList(EmpName, CHOICE);   //PASSING TWO PARAMETERS EMPNAME AND CHOICE STORIG THE RETURN VALUE IN EMPLIST.

            for (int z = 0; z < EmpList.Count; z++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (CHOICE == 1 || CHOICE == 2) { Console.WriteLine("\t|-- " + EmpList[z].ID + "\t" + EmpList[z].Name + "\t" + EmpList[z].DOB + "\t" + EmpList[z].Salary + " --|"); }
                else { Console.WriteLine("\nWRONG CHOICE RE-TRY AGAIN"); SelectEmployeeByName(); }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Options();
        }
//UPDATE-EMPLOYEE==========================================================================================================================================================================================
        //[HTTP-UPDATE?]
        public void UpdateEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Employee emp = new Employee();

            Console.WriteLine("\n|--------------------------------------------------------------------<UPDATE EMPLOYEE DETAILS BY ID>-----------|\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("\nENTER THE EMPLOYEE ID WHERE UPDATE NEEDS TO BE DONE :");  //ENTER THE ID TO REFER INTO THE LIST
            int ID = Convert.ToInt32(Console.ReadLine());

            Employee k = FindId(ID);                                                       //CHECK IF THE GIVEN ID IS ACTUALLY PRESENT IN THE LIST

            if (k != null)                                                                 //IF GIVEN ID IS PRESENT IN THE LIST , THEN :
            {
                employees.Remove(k);                                                       //remove all elements in that list
                emp.ID = ID;                                                               //since emplID is confiremed to be equal to given id , assing EmployeeId as main ID 
               
                Console.WriteLine("\nNEW NAME TO BE UPDATED");                             //UPDATED NAME 
                emp.Name = Console.ReadLine();
                Console.WriteLine("\nNEW DOB TO BE UPDATED");                              //UPDATED DOB
                emp.DOB = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\nNEW SALARY TO BE UPDATED");                           //UPDATED SALARY
                emp.Salary = Convert.ToInt32(Console.ReadLine());

                employees.Add(emp);                                                        //ADD ALL THE NEW UPDATED DETAILS TO THE MAIN LIST.   
            }
            else { Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("GIVEN ID DOES NOT EXIST IN THE LIST...!!");  }
            
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------------");
            Options();
        }
//EXIT-TERMINAL==========================================================================================================================================================================================
        public void Exit()
        {
            Environment.Exit(0);                                   //USING INBUILT CONSOLE FUNCTION TO EXIT THE TERMINAL.
        }


//<<<<<<<<<<============================================================MAIN FUNCTION====================================================================================================================
        public static void Main(string[] args)
        {
            Program firstMethodCall = new Program();               //CREATING AN INSTANCE OF OBJECT FOR THE CLASS PROGRAM. Like an arrow to target particular target...!
            firstMethodCall.Options();                             //CALLINg Options() Method through object. just like using blunt arraw to retrive ball from the tree.
        }
    }
}
