/*
users are given choices for the operations to be performed.

Operations range from :
Adding ,
 Deleting ,
 Update-Display
 then Exit from terminal functions.

Here we use list with variables declared in the constructor.
Lists containing two variables (ID and NAME ).

we use OOP(Classes and Object) for programing frame.
with multiple methods .  
*/
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http; 
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace EmpList
{
    class Employee //CLASS EMPLOYEE CONTAINING 2 GLOBAL VARIABLES FOR LIST OF int & string TYPE 
    {
        public int ID { get; set; } //CONSTRUCTOR 1 for ID
        public string Name { get; set; } //CONSTRUCTOR 2 for Name
    }

    class Program //MAIN CLASS FOR LIST DECLAIRARTION , METHODS AND MAIN METHOD
    {
        List<Employee> employee = new List<Employee>(); //LIST DECLAIRATION

        public void Options() //METHOD 1 FOR SELECTING OPTIONS FROM USER
        {
                    Console.ForegroundColor = ConsoleColor.Cyan;
            //giving options to the users to enter the options.
            Console.WriteLine("\n<--||========WELCOME TO THE TERMINAL========||-->\n");
            Console.WriteLine("\t ENTER YOUR REQUEST BASED ON THE OPTIONS : ");
            Console.WriteLine("\t ENTER (1) -> ADDING EMPLOYEE ");
            Console.WriteLine("\t ENTER (2) -> DELETING EMPLOYEE ");
            Console.WriteLine("\t ENTER (3) -> VIEW UPDATED LIST ");
            Console.WriteLine("\t ENTER (4) -> EXIT THE TERMINAL \n");
            Console.WriteLine("---------ENTER YOUR OPTIONS---------");
                    Console.ForegroundColor = ConsoleColor.White;
            //taking input from the user and storing it in "key" variable of int type.
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
                    Console.ForegroundColor = ConsoleColor.White;

            //checking if key is in range from 1 to 4 then assigning it to specific tasks by calling respective methods.
            if (key == 1) AddEmployee();
            else if (key == 2) DeleteEmployee();
            else if (key == 3) UpdatedList();
            else if (key == 4) Exit();
            //if key value is out of range (1 to 4) print errror message and show options again..!
            else
            {
                        Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---WRONG KEY TRY AGAIN---");
                        Console.ForegroundColor = ConsoleColor.White;
                Options();
            }
        }

        
        public void AddEmployee() //METHOD 2 FOR ADDING EMLOYEE DETAILS(ID ,Name) TO THE LIST
        {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Object declairation for the Employee Class to acess the ID and Name , also to push data into LIST using "employee"
            Employee emp = new Employee();
            //taking input from users both for ID and Name
            Console.WriteLine("\n <ADD> ENTER THE EMPLOYEE ID : ");
                    Console.ForegroundColor = ConsoleColor.White;
            emp.ID = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n <ADD> ENTER THE EMPLOYEE NAME : ");
                    Console.ForegroundColor = ConsoleColor.White;
            emp.Name = Console.ReadLine();

            //adding the user entered data (Id and Name ) into the List using employye as LIST object , Add as inbuilt function, emp as Employee object.
            employee.Add(emp);
            //redisplaying Options for users 
            Options();
        }

        public int FindEmployee(int remID, int updID)
        {
            for(int i = 0; i < employee.Count; i++)
            { 
            Employee emp = employee[i];
                if(emp.ID == remID)
                {
                    employee.RemoveAt(i);
                    Options();

                }
                else if(emp.ID == updID)
                {
                    Console.WriteLine("|"+ emp.ID + "--" + emp.Name + "|");
                    Options();
                }
            }
            Console.WriteLine("|----NOT FOUND----|");
            Options();
            return '\0';
            
        }
    

        public void DeleteEmployee() //METHOD 3 DELETING THE EMPLOYEE DETAILS BY ACESSING ID 
        {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
            //taking input from the user to take ID which must be removed from the Employee List
            Console.WriteLine("\n <DELETE> ENTER THE EMPLOYEE ID OF THE TABLE TO BE DELETED : ");
                    Console.ForegroundColor = ConsoleColor.White;
            int remID = Convert.ToInt32(Console.ReadLine());

            FindEmployee(remID, 0);
            
            //using loop to check if the user entered ID exists in the employee LIST
           /* for(int i = 0; i < employee.Count; i++)
            {
                Employee emp = employee[i];
                if(emp.ID == remID)
                {
                    employee.RemoveAt(i);
                    break;
                }
            }
            Options();*/
        }
    

        public void UpdatedList() //METHOD 4 DISPLAYING THE CONTENT OF THE LIST AFTER UPDATION(even after adding and deleting)
        {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" \n <UPDATE> ENTER THE EMPLOYEE ID TO BE AACCESSED : ");
                    Console.ForegroundColor = ConsoleColor.White;
            int updID = Convert.ToInt32(Console.ReadLine());
            FindEmployee(0,updID);

           /* bool empExist = false;
            for (int j =0; j < employee.Count; j++)
            {
                Employee emp = employee[j];
                if(emp.ID == updID)
                {
                            Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("| " + emp.ID + " --- " + emp.Name + " |");
                            Console.ForegroundColor = ConsoleColor.White;
                    empExist = true;
                    //break;
                }  
            }
                if(empExist == false)
            {
                        Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("|---NOT FOUND IN THE EMPLOYEE LIST---|");
                        Console.ForegroundColor = ConsoleColor.White;
            }*/


            Options();

        }
    

        public void Exit() //FUNCTION 5 FOR EXITING THE TERMINAL
        {
            System.Environment.Exit(0);
        }


        //MAIN METHOD WHERE THE EXECUTION STARTS FIRST
        public static void Main(String[] args)
        {
            Program em = new Program(); //object creation for the class Program
            em.Options();               //calling Options() method using object as the Fist Method for users to enter input.
        }
    }
}
