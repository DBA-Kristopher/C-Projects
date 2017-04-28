using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------------
            // Programming Assignment: 	LAB1A
            // Developer: 	Kristopher Smith     
            // Date Written: 	7/25/2014
            // Purpose: 	DIVE Scoring Program
            // ---------------------------------------------------------------




            //Declare variables

            string again, name, city;
      
            double difficulty, highScore=-1, lowestScore=11, judgeScore, finalScore;

            //Loop each Diver input process
            do
            {

                //Request and store basic diver info
                Console.Write("Divers name: ");
                name = Console.ReadLine();
                Console.Write("Divers city: ");
                city = Console.ReadLine();
                Console.Write("Level of difficulty: ");
                difficulty = Convert.ToDouble(Console.ReadLine());
                //Promt user if input outside parameter
                while (difficulty < 1 || difficulty > 1.67)
                {Console.Write("Level of difficulty between 1 and 1.67: ");
                    difficulty = Convert.ToDouble(Console.ReadLine());}
                double total = 0;
                
                //Collect all 5 judges scores
                for (int i = 1; i < 6; i++)
                {
                   
                    //Collect judges scores
                    Console.Write("Please enter judge number " + (i) + " score: ");
                    judgeScore = Convert.ToDouble(Console.ReadLine());
                    while (judgeScore < 0 || judgeScore > 10)
                    {Console.Write("Please enter a judge score between 0 and 10: ");
                    judgeScore = Convert.ToInt32(Console.ReadLine());}
                    //Calculate data including: High Low Scores
                    if (judgeScore > highScore)
                    { highScore = judgeScore; }
                    if (judgeScore < lowestScore)
                    { lowestScore = judgeScore; }
                    total+= judgeScore;
                }
                //Calculate the final score
                finalScore = (total - lowestScore - highScore) / 3 * difficulty;
                //Print out name city and final score
                Console.WriteLine("\nDivers name: {0} \nDivers city: {1} \nFinal score: {2}", name, city, finalScore);
                Console.WriteLine("\nAnother diver (Y/N)?");
                again = Console.ReadLine().ToUpper(); 
            } while (again == "Y");

            Console.ReadLine();

        }
    }
}
