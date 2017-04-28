using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cis170week2_iLAB_2_PART_A
{
    class Program
    {
        static void Main(string[] args)
        // ---------------------------------------------------------------
        // Programming Assignment: 	LAB2A
        // Developer: 	Kristopher Smith
        // Date Written: 	7/18/2014
        // Purpose: 	Shipping Program
        // ---------------------------------------------------------------
        {
            double purchase= -2;

            do
            {
                Console.WriteLine("Hello and welcome \n \nPlease enter in the purchase amount to recieve your shipping cost.");
                purchase = Convert.ToDouble(Console.ReadLine());
            } while (purchase < 0);
     
                
            if (purchase > 0 && purchase <= 250)
            {
                Console.WriteLine("Purchase amount: {0:C} \nShipping amount: $5.00 ", purchase);
            }
            else if (purchase > 250 && purchase <= 500)
            {
                Console.WriteLine("Purchase amount: {0:C} \nShipping amount: $8.00 ", purchase);
            }
            else if (purchase > 500 && purchase <= 1000)
            {
                Console.WriteLine("Purchase amount: {0:C} \nShipping amount: $10.00 ", purchase);
            }
            else if (purchase > 1000 && purchase <= 5000)
            {
                Console.WriteLine("Purchase amount: {0:C} \nShipping amount: $15.00 ", purchase);
            }
            else if (purchase >= 5000)
            {
                Console.WriteLine("Purchase amount: {0:C} \nShipping amount: $20.00 ", purchase);
            }
            else 
            {
                Console.WriteLine("Invalide amount entered. Please enter more than $0.00");

            }

            Console.WriteLine("Press enter key to close");

            Console.ReadLine();

        }
    }
}
