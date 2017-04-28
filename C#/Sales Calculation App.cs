using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LAB1C
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------------
            // Programming Assignment: 	LAB1B
            // Developer: 	Kristopher Smith
            // Date Written: 	7-11-2014
            // Purpose: 	Payroll Program
            // ---------------------------------------------------------------

            //declare data type
            double weeklySales, grossPay, fedTax, socSecurity, retirement, totDeductions, takeHomePay;
 

            //Input user weekly sales
            Console.Write("Please enter in weekly sales ");

            weeklySales = Convert.ToDouble(Console.ReadLine());

            //Caluculate user commsion

            grossPay = weeklySales * 0.07;
                
                fedTax = grossPay * .18;
                socSecurity=grossPay*.06;
                retirement = grossPay * .10;
               




            //Calculate user total dedutions 
                totDeductions = fedTax + socSecurity + retirement;

            //Output total data
                takeHomePay = grossPay - totDeductions;
                Console.WriteLine("Total sales amount: {0:C}",weeklySales);
                Console.WriteLine("Gross Pay: {0:C}",grossPay);
            Console.WriteLine("Federal taxes paid: {0:C}",fedTax);
            Console.WriteLine("Social Security paid: {0:C}", socSecurity);
            Console.WriteLine("Retirement contributions: {0:C}",retirement);
            Console.WriteLine("Total Deduction: {0:C}",totDeductions);
            Console.WriteLine("Take Home Pay: {0:C}",takeHomePay);
               
                Console.ReadLine();


            

        }
    }
}
