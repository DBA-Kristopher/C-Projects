using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            double test_score = 0;
            string final_grade = "F";
            string full_name;
            double test_scorePercentage = 1000;


            //Input
            Console.Write("What's your full name?: ");
            full_name = Console.ReadLine();
            Console.Write("\nEnter test_score: ");
            test_score = Convert.ToDouble(Console.ReadLine());






            //Process



                test_scorePercentage = test_score / 100;


            if (test_scorePercentage <= 0.60 )
            { final_grade = "F"; }


            



                if (test_scorePercentage >= 0.60 && test_scorePercentage <=69)
                { final_grade = "D"; }



                if (test_scorePercentage >= 0.70 && test_scorePercentage <= .79)
                { final_grade = "C"; }

   
                if (test_scorePercentage >= 0.80 && test_scorePercentage <= .89)
                { final_grade = "B"; }

            if (test_scorePercentage >= 0.90 && test_scorePercentage <= 100)
            { final_grade = "A"; }


            //Output

            Console.WriteLine("The percentage is  " + test_scorePercentage.ToString("P") + " and the letter grade is  " + final_grade);
            Console.ReadKey();
        }
    }
}