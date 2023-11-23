global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmpList
{
    public class Employee                                       //CREATING A CLASS TO ACCESS ALL THE VARIABLES THROUGH OUT THE PROGRAM CLASS 
    {
        public int       ID     { get; set; }                   //DECLAIRING EACH VARIABLESS AS PUBLIC FOR ACCESS THROUGHOUT THE PROGRAM 
        public string    Name   { get; set; }                   //GIVING CORRESPONDING DATA TYPES FOR THE VARIABLES 
        public DateTime  DOB    { get; set; }                   //THE DATA TYPE DateTime CAN HOLD DATE BUT IT ALSO HOLDS TIME AS WELL, WE CAN USE DateOnly TYPE
        public int       Salary { get; set; }
    }

    public class Program                                         //CREATING THE PROGRAM CLASS
    {
        static List<Employee> employees = new List<Employee>();  //CREATING A LIST WHICH IS A REFERNCE TO THE Employee CLASS ITS INSTANCE BEING employees

        public void Options()                                    //CREATING OPTIONS METHOD TO TAKE COMMAND FROM USERS 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n|============================EMPLOYEE DATA OPTIONS=====================|");  //PRE WRITTEN MENU OPTIONS
            Console.WriteLine("\t1)-ADDING EMPLOYEE DETAILS");
            Console.WriteLine("\t2)-REMOVING EMPLOYEE DETAILS");
            Console.WriteLine("\t3)- UPDATED EMPLOYEE DETAILS BY ID");
            Console.WriteLine("\t4)- UPDATED EMPLOYEE DETAILS BY NAME");
            Console.WriteLine("\t5)- EXIT THE TERMINAL");
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
            else if (key == 5) { Exit();                 }
            else               { Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("|--W-R-O-N-G  O-P-T-I-O-N-S--|"); Console.ForegroundColor = ConsoleColor.White; Options(); }


        }

        public Employee CheckId(int EmployeeID)        //METHOD TO CHECK IF THE GIVEN ID ACTUALLY CONTAINS IN THE LIST OR NOT ..!
        {
            for (int i = 0; i < employees.Count; i++)  //CREATING A LOOP TO TEST IF THE GIVEN ELEMENT MATCHES WITH THE INDEX OF LIST CONTENT
            {
                Employee emp = employees[i];           //TRAVERSING THROUGH THE LIST USING ARRAY 

                if (emp.ID == EmployeeID)              //COMPARING THE GIVEN ELEMENT WITH THE LIST 
                {
                    return emp;                        //IF TRUE RETURNS emp WHICH CONTAINS ALL THE EMPLOYEE DETAILS 
                }
            }

            return null;                               //IF NOT FOUND RETURNS NULL, MEANING EMPLOYEE NOT FOUND IN THE LIST
        }

        public List<Employee> EmployeeList(string EmpNme, int CHOICE)          //CREATING A METHOD OF TYPE LIST WITH INPUT VALUES OF TYPE string AND int
        {
            List<Employee> TempList = new List<Employee>();                    //WE CREATE A LIST TO STORE ALL THE DATA THAT EIGTHER STARTS WITH GIVEN DATA OR CONTAINS 

            if (CHOICE == 1)                                                   //WE PERFORM OPERATIONS BESED ON USER CHOICE IF 1)THEN TEST STARTS WITH CONDITION.
            {
                for (int i = 0; i < employees.Count; i++)                      //WE TRAVERSE THE LIST TO FIND IF USER GIVEN NAME IS PRESENT IN LIST OR NOT 
                {
                    Employee emp = employees[i];                               //ARRAY THAT TRAVERSES THE LIST BASED ON INDEX VALUE 

                    if (emp.Name.StartsWith(EmpNme))                           //TESTING OUT THE STARTS WITH CONDITION 
                    {
                        TempList.Add(emp);                                     //IF TRUE THEN THE EMLOYEE DETAILS WILL BE ADDED TO THE NEW LIST TempList
                    }
                }
                return TempList;                                               //AFTER ALL THE LIST IS CHECKED THEN WE RETURN THE LIST TO THE CALLING METHOD FOR FUTHER WORK

            }

            else if (CHOICE == 2)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Employee emp = employees[i];

                    if (emp.Name.Contains(EmpNme))
                    {
                        TempList.Add(emp);
                    }
                }
                return TempList;

            }

            else { return null; }

        }

        public void AddEmployee()
        {
            Employee emp = new Employee();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<ADD EMPLOYEE DETAILS>-----------|");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nENTER YOUR ID :");
            emp.ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nENTER YOUR NAME :");
            emp.Name = Console.ReadLine();

            Console.WriteLine("\nENTER YOUR DATE OF BITH");
            emp.DOB = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nENTER YOUR SALARY");
            emp.Salary = Convert.ToInt32(Console.ReadLine());

            employees.Add(emp);

            Options();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void RemoveEmployee()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<REMOVE EMPLOYEE DETAILS>-----------|");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nENTER THE ID OF THE EMPLOYEE EHICH NEEDS TO BE REMOVED :");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());

            Employee x = CheckId(EmployeeID);

            if (x != null) { Console.WriteLine("\nEMPLOYEE LIST FOUND REMOVING " + x.ID + " --DONE SUCCESSFULLY"); employees.Remove(x); Options(); }
            else { Console.WriteLine("\n|--- LIST NOT FOUND IN THE TABLE (try again.!)---|"); Options(); }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SelectEmployeeById()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<SELECT EMPLOYEE DETAILS BY ID>-----------|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nENTER THE ID OF THE EMPLOYEE EHICH NEEDS TO BE SELECTED :");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());

            Employee y = CheckId(EmployeeID);

            Console.ForegroundColor = ConsoleColor.Green;
            if (y != null) { Console.WriteLine("\t|-- " + y.ID + "\t" + y.Name + "\t" + y.DOB + "\t" + y.Salary + " --|"); Options(); }
            else { Console.WriteLine("\nWRONG ID PLEASE TRY AGAIN ...!!"); Options(); }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void SelectEmployeeByName()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n|--------------------------------------------------------------------<SELECT EMPLOYEE DETAILS BY NAME>-----------|\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n ENTER OPTION FROM THE FLOOWING : \n\n \t 1)-CHECK IF THE LIST HAS NAMES STARTING WITH \n \t 2)-CHECK THE LIST CONTAINS THE ELEMENT \n");
            Console.WriteLine("\n ENTER OPTION FROM THE FLOOWING : \n\n \t 1)-CHECK IF THE LIST HAS NAMES STARTING WITH \n \t 2)-CHECK THE LIST CONTAINS THE ELEMENT \n");
            int CHOICE = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nENTER THE NAME OF THE EMPLOYEE EHICH NEEDS TO BE SELECTED :");
            string EmpName = Console.ReadLine();

            List<Employee> EmpList = EmployeeList(EmpName, CHOICE);

            for (int z = 0; z < EmpList.Count; z++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (CHOICE == 1) { Console.WriteLine("\t|-- " + EmpList[z].ID + "\t" + EmpList[z].Name + "\t" + EmpList[z].DOB + "\t" + EmpList[z].Salary + " --|"); }
                else if (CHOICE == 2) { Console.WriteLine("|-- " + EmpList[z].ID + "\t" + EmpList[z].Name + "\t" + EmpList[z].DOB + "\t" + EmpList[z].Salary + " --|"); }
                else { Console.WriteLine("\nWRONG CHOICE RE-TRY AGAIN"); SelectEmployeeByName(); }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------------------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Options();
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }



        public static void Main(string[] args)
        {
            Program firstMethodCall = new Program();
            firstMethodCall.Options();
        }
    }
}
