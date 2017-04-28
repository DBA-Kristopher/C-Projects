using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlderaanVolume
{

    class Program
    {
        //_________Date: 8/8/2014
        //_________Name: Kristopher Smith
        //_________Program Name: Tournament Stats
        //_________
        
        static void Main(string[] args)
        {
            int numPlayers=0;
            double averageScore=0;
            string[] names = new string[100];
            double[] scores = new double[100];
            
                 inputData(names,scores, ref numPlayers);
                 DisplayPlayerData(names, scores, numPlayers);
                 averageScore = CalculateAverageScore(scores, numPlayers);
                 DisplayBelowAverage(scores, names, averageScore);

            Console.ReadLine();
        }


        
        //---------------------------------------------InputData( ):----------------------------------------------------------------

          public static void inputData(string[] names, double[] scores, ref int  numPlayers)
        {
            while (true)
            {

                Console.Write("Enter Player Name (Q to quit): ");
                names[numPlayers] = Console.ReadLine();
                if (names[numPlayers] == "Q")
                {
                    break;
                }


                Console.Write("Enter score for {0}: ", names[numPlayers]);
                scores[numPlayers] = Convert.ToDouble(Console.ReadLine());
                numPlayers++;

            }
            
        }
        //----------------------------------------------DisplayPlayerData( ):---------------------------------------------------------------
        static void DisplayPlayerData(string[] names, double[] scores, int numPlayers)
        {
            
            Console.WriteLine("Name\tScore");
            for (int i = 0; i < names.Length; i++)
            {
                if (scores[i] > 0)
                {
                    Console.WriteLine("\n" + names[i] + "\t" + scores[i]);
                }
            }

        }

        //---------------------------------------------CalculateAverageScore( ):----------------------------------------------------------------
        public static double CalculateAverageScore(double[] scores, int numPlayers)
 {
     double total=0, average=1;
    
     for (int i = 0; i < scores.Length; i++)
     {
       
         total = total +scores[i];
         
     }
            
     average = total/numPlayers;
     Console.WriteLine("Average Score: "+average);

     return average;
        }

        //-----------------------------------------------DisplayBelowAverage( ):------------------------------------------------------------- 
        public static void DisplayBelowAverage(double[] scores,string[] names,double averageScore)
        {
            Console.WriteLine("Players below average score: \n\n\nName\tScore");
        for (int i = 0; i < scores.Length; i++)
    {

    if (scores[i] < averageScore && scores[i] > 0.1)
    {

        Console.WriteLine("\n" + names[i] + "\t" + scores[i]);
    }
    }
    }
    }
}
