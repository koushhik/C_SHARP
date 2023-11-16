using System;
using System.Linq;  
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Net;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace Practice
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static List<Employee> employees = new List<Employee>();

        public int Options()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Program em = new Program();
            Console.WriteLine("-----------------------OPTIONS-------------------");
            Console.WriteLine("ENTER THE NUMBER TO CHOOSE YOUR OPTIONS : \n");
            Console.WriteLine("\t1) ADDING EMPLOYEE DETAILS ");
            Console.WriteLine("\t2) REMOVING EMPLOYEE DETAILS ");
            Console.WriteLine("\t3) SELECTING EMPLOYEE DETAILS ");
            Console.WriteLine("\t4) EXITING THE PROMPT \n");
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("#) CHOOSE YOUR OPTION: ");
            int Key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t");

            if (Key == 1) { empAdd(); }
            else if (Key == 2) { empRemove(); }
            else if (Key == 3) { empSelect(); }
            else if (Key == 4) { empExit(); }
            else { Console.WriteLine("--< WRONG OPTION  TRY AGAIN..!!-->"); Options(); }
            return Key;
        }

        public void empAdd()
        {
            Employee emp = new Employee();
            Console.WriteLine("->ENTER YOUR ID: ");
            emp.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("->ENTER YOUR NAME : ");
            emp.Name = Console.ReadLine();
            employees.Add(emp);
            Options();
        }

        public Employee FindEmployee(int EID) //a class can be used as a method
        {


            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Employee emp = employees[i];
                    if (emp.ID == EID)
                    {

                        return emp;
                    }
                }
                return null; //in a class(method) we can return null value

            }
            {
                for(int i = 0; i < employees.Count;i++)
                {
                    Employee emp = employees[i];
                    if(emp.ID == EID)
                    {
                        return emp;
                    }
                    return null;
                }
            }


        }
        public void empRemove()
        {
           
                Console.WriteLine("->ENTER THE EMPLOYEE ID IN THE TABLE TO BE REMOVED :");
                int EID = Convert.ToInt32(Console.ReadLine());
                FindEmployee(EID);

            for (int i = 0; i < employees.Count; i++)
                {
                    Employee emp = employees[i];

                    if (emp.ID == EID)
                    {
                        employees.RemoveAt(i);
                        break;
                    }
                }
            Options();
        }

        public void empSelect() 
        {
            
            Console.WriteLine("->ENTER THE EMPLOYEE ID TO BE ACCESSED : ");
            int EID = Convert.ToInt32(Console.ReadLine());
            FindEmployee(EID);



            bool empExists = false;
            for (int j = 0; j < employees.Count; j++)
            {
                Employee emp = employees[j];
                if (emp.ID == EID)
                {

                    Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                    empExists = true;
                    break;

                }

            }
            if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }
            Options();
        }

        public void empExit()
        {
            Environment.Exit(0);
        }

    
        public static void Main(string[] args)
        {
            Program em = new Program();
            em.Options();
        }     
    }
}



//using employee id only as parameter object

/*if (k == 2)
            {
                if (DIS == 0)
                    for (int i = 0; i < employees.Count; i++)
                    {
                        Employee emp = employees[i];

                        if (emp.ID == EID)
                        {
                            employees.RemoveAt(i);
                            break;
                        }

                    }

                Options();

            }
            else if (k == 3)
            {
              if(EID == 0)
              { 
                bool empExists = false;
                for (int j = 0; j < employees.Count; j++)
                {
                    Employee emp = employees[j];
                    if (emp.ID == DIS)
                    {

                        Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");

                        empExists = true;
                        break;

                    }

                }
                   if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }
                   Options();

              }
            }*/




/*public void empRemove()
        {
            int DIS = 0;
            Console.WriteLine("->ENTER THE EMPLOYEE ID IN THE TABLE TO BE REMOVED :");
            int EID = Convert.ToInt32(Console.ReadLine());
            Empall(2,EID,DIS);
        }

        public void empSelect() 
        {
            int EID = 0;
            Console.WriteLine("->ENTER THE EMPLOYEE ID TO BE ACCESSED : ");
            int DIS = Convert.ToInt32(Console.ReadLine());
            Empall(3,EID,DIS);
        }*/





/*Console.WriteLine("Enter the EMPLOYEE ID to be acessed : ");
            int DIS = Convert.ToInt32(Console.ReadLine());
            bool empExists = false;
            for (int j = 0; j < employees.Count; j++)
            {
                Employee emp = employees[j];
                if (emp.ID == DIS)
                {
                    
                    Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                    
                    empExists = true;
                    break;
                   
                }
                
            }
            if (empExists == false) { Console.WriteLine("not found"); }
            Options();*/


/* Console.WriteLine("Enter The EMPLOYEE ID of the table to be removed :");
 int EID = Convert.ToInt32(Console.ReadLine());
 for(int i = 0; i < employees.Count; i++) 
 {
     Employee emp = employees[i];
     if(emp.ID == EID) 
     {
      employees.RemoveAt(i);
         break;
     }



 }

     Options();*/




/*
 * 
 * 
 * 
 * 
 * public void EmployeData(int EID,int DIS)
        {
            if (EID > 0)
            {
                for (int i = 0; i < employees.Count; i++)
                {
                    Employee emp = employees[i];

                    if (emp.ID == EID)
                    {
                        employees.RemoveAt(i);
                        break;
                    }
                }
                Options();
                
            }
            else if(DIS > 0)
            {
                bool empExists = false;
                for (int j = 0; j < employees.Count; j++)
                {
                    Employee emp = employees[j];
                    if (emp.ID == DIS)
                    {

                        Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                        empExists = true;
                        break;

                    }

                }
               
                if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }
                Options();
            }
             //else { Console.WriteLine("|--<NOT FOUND>--|"); Options(); }
        }
 * 
 * 
 * 
 */


/* if (EID != 0)
           {
               for (int i = 0; i < employees.Count; i++)
               {
                   Employee emp = employees[i];
                   if (emp.ID == EID)
                   {
                       employees.RemoveAt(i);
                       break;
                   }
               }
               Options();
           }
           else if (DIS != 0)
           {
               bool empExists = false;
               for (int j = 0; j < employees.Count; j++)
               {
                   Employee emp = employees[j];
                   if (emp.ID == DIS)
                   {
                       Console.WriteLine("--------");
                       Console.WriteLine("|" + emp.ID + " - " + emp.Name + "|");
                       Console.WriteLine("--------");
                       empExists = true;
                       break;
                   }
               }
               if (empExists == false) { Console.WriteLine("|--<NOT FOUND>--|"); }



Options();*/


/*public int FindEmployee(int x)
      {
          //for(int i = 0; i < employees.Count; i++) 
          //{
              //Employee emp = employees[i];
              //if (emp.ID == x)
              //{
                  return x = 1;
              //}

          //}

      }*/
