using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace CIS170_Week_5_Lab_Part_B
{
    class Program

        // ---------------------------------------------------------------
    // 
    // Developer: 	Kristopher Smith
    // Date Written: 	8/10/2014
    // Purpose: 	Alphabetical Order Program
    // ---------------------------------------------------------------

    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();

            while (true)
            {
                Console.Write("\n\nEnter Last Name: ");
                string name = Console.ReadLine();
                Console.Write("\nKeep going? (Y/N): ");
                string answer = Console.ReadLine();
                if (answer == "Y" || answer == "y")
                {
                    names.Add(name);
                }
                else
                {
                    break;
                }
            }
                Console.Write("\n"+names.Count + " last names entered\n");
                
                Console.WriteLine("\n\nNames in Ascending Order\n");
                names.Sort();
                for (int i = 0; i < names.Count; i++)
                {
                    Console.Write(names[i]+"\n");
                }
                Console.WriteLine("\n\nNames in Descending Order\n");
                names.Reverse();
                for (int i = 0; i < names.Count; i++)
                {
                    Console.Write(names[i]+"\n");
                }



            
             
            Console.ReadLine();
        }
    }
}
