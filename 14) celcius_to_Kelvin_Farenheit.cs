
/*
      Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.
     
           TEST DATA:         
              Enter the amount of celsius: 30
              Expected Output:
              Kelvin = 303
              Fahrenheit = 86

*/

using System;

namespace Practice
{
    class program   
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER THE AMOUNT IN CELCIUS : ");   //we take the input from the user for celcius value
            int a = Convert.ToInt32(Console.ReadLine());                      
            int k = a + 273;                                       //To calculate CELCIUS TO KELVIN THE FORMULA IS : KELVIN = CELCIUS + 273.15 BUT SINCE WE USE INT AND TO ROUND OFF WE USE 273.
            double f = a * 1.8 + 32;                               //TO CALCULATE CELCIUS TO FAREINHEIT WE USE THE FORMULA (CELCIUS * 9/5) + 32 FOR SIMPLIFICATION PURPOSE WE USE ....(CELCIUS * 1.8) + 32 AND WE USE DOUBLE AS 1.8 IS A FRACTION/ DECIMAL.
            Console.WriteLine("KELVIN : "+k);                      //ISPLAY THE OUTPUT.
            Console.WriteLine("FARENHEIT : "+f);


        }
            
    }

}

