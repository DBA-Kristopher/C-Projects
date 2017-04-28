using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CIS247_WK1_Lab_LASTNAME
{
    
//Program Header
//Program Name: Basic User Interface
//Programmer: Kristopher Smith
//
//Program Description: Test Program

    class Program
    {
        static void Main(string[] args)
        {
           //declare variables
            string input, name, sample;
            Int32 age;
            double galMileage;
            ApplicationUtilities u = new ApplicationUtilities();
            
             
           
            Console.WriteLine("Working Environment \nName: Kristopher \nThis program accepts user input as a string, then makes the appropriate data conversation");


           
            //call DisplayApplicationInformation
            //call DisplayDivider(“Start Program”)
            //call DisplayDivider(“Get Name”)
            Console.WriteLine("******************************* Start Program *******************************");
            Console.WriteLine("\n******************************* Get Name ************************************");
            //Get users name the re display name
            Console.Write("Enter the Name: ");

            name = Console.ReadLine();
            Console.Write("Your name is: "+name);
            Console.WriteLine("\n******************************* Get Age ************************************");
            //Get Users Age 
            Console.Write("Enter your age: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: "+age);
            //Get Users Gas Mileage
            Console.WriteLine("\n******************************* Get Mileage **********************************");
            Console.Write("Enter the gas mileage: ");
            galMileage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your car MPG is: "+galMileage);
            //End Program
            Console.WriteLine("\n******************************* End Program **********************************");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }



    }


}
