using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CIs_170_week_2_lab_part_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------------
            // Programming Assignment: 	LAB2B
            // Developer: 	Kristopher Smith
            // Date Written: 	7/18/2014
            // Purpose: 	Network Callsign 
            // ---------------------------------------------------------------

            Console.WriteLine("Translate TV Channel Number to Call Sign");

            int channel= 2;

            while (channel > 0)
            {

                Console.Write("Please enter the channel: ");
                channel = Int32.Parse(Console.ReadLine());



                switch (channel)
                {
                    case 1:
                        Console.WriteLine("WTV \nTo exit enter a negative number.");
                        break;

                    case 2:
                        Console.WriteLine("NMTV\n\nTo exit enter a negative number.");
                        break;

                    case 3:
                        Console.WriteLine("KTLA\n\nTo exit enter a negative number.");
                        break;
                    case 4:
                        Console.WriteLine("TZAR\n\nTo exit enter a negative number.");
                        break;
                    case 5:
                        Console.WriteLine("STARZ\n\nTo exit enter a negative number.");
                        break;
                    case 6:
                        Console.WriteLine("Not avaiable in your area.\n\nTo exit enter a negative number.");
                        break;
                    case 7:
                        Console.WriteLine("HALAX\n\nTo exit enter a negative number.");
                        break;
                    case 8:
                        Console.WriteLine("SRIV\n\nTo exit enter a negative number.");
                        break;
                    case 9:
                        Console.WriteLine("CODG\n\nTo exit enter a negative number.");
                        break;
                    case 10:
                        Console.WriteLine("GTAV\n\nTo exit enter a negative number.");
                        break;
                    default:
                        Console.WriteLine("You must upgrade your current subscription to view this channel.\n\nTo exit enter a negative number.");
                        break;

                }
            }


                  Console.ReadLine();


           
        



        }
    }
}
