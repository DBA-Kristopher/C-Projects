using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cis_170_Week_4_Lab
{
    class Program
    {
        static void Main(string[] args)

            //Develpoer Name  Kristopher Smith
            // Date 8/2/2014
        //Program Name    Phone Dialing Program

        {
            //Main Delcare variables and pass them
            Char n1='a', n2='b', n3='c', n4='d', n5='e', n6='f', n7='g';
            int checkValue = 1;
            do
            {
            checkValue= getInput(ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7);
                if (checkValue==-5)
                {
                    break;
                }

               
                switch (checkValue)
                {
                    case 1:
                        Console.WriteLine("Number cannot start with 555");
                        break;

                    case 2:
                        Console.WriteLine("Number cannot begin with 0");
                        break;


                    case 3:
                        Console.WriteLine("Please enter number or letters only");
                        break;
                        
                    default :

                        ShowResults(ref n1, ref n2, ref n3, ref n4, ref n5, ref n6, ref n7);
                        break;
                       }
                  //ProcessInput()

            }while(true);
            Console.ReadLine();
        }

        //Method catches input, print results
        public static int getInput(ref char n1, ref char n2, ref char n3, ref char n4, ref char n5, ref char n6, ref char n7)
        {
            Console.WriteLine("Please enter 7 digit phone number or 'Q' to quit.");
            n1 = Convert.ToChar(Console.Read());
            if (n1 == 'Q')
            { return -5; }
      
            n2 = Convert.ToChar(Console.Read());
            n3 = Convert.ToChar(Console.Read());
            n4 = Convert.ToChar(Console.Read());
            n5 = Convert.ToChar(Console.Read());
            n6 = Convert.ToChar(Console.Read());
            n7 = Convert.ToChar(Console.Read());
            Console.ReadLine();
            
            if (n1 == '0')
            { return 2; }
            if (n1 == '5' && n2 =='5'&& n3 =='5') 
            {
                return 1;
        }
            if (ToDigit(ref n1) == 4)
            {
                return 3;
            }
            if (ToDigit(ref n2) == 4)
            {
                return 3;

            }
            if (ToDigit(ref n3) == 4)
            {
                return 3;
            } 
            if (ToDigit(ref n4) == 4)
            {
                return 3;
            } 
            if (ToDigit(ref n5) == 4)
            {
                return 3;
            } 
            if (ToDigit(ref n6) == 4)
            {
                return 3;
            } 
            if (ToDigit(ref n7) == 4)
            {
                return 3;
            }




            return 0;

           
        }
        static void ShowResults(ref char n1, ref char n2, ref char n3, ref char n4, ref char n5, ref char n6, ref char n7)
    {

        Console.WriteLine("Great phone number: " + n1+  n2+   n3+  "-"+n4+ n5+ n6+ n7);
    }
        public static int ToDigit(ref char d)
        {
            d= Char.ToUpper(d);
            switch (d)
            {case 'A': case 'B' : case 'C' : case '2':
                    d= '2';
                    break;
                case 'D':case 'E':case'F' :case'3':
                    d='3';
                    break;
                case 'G':case 'H': case 'I': case '4':
                    d='4';
                    break;
                    case 'J':case 'K':case 'L':case '5':
                    d='5';
                    break;
                    case 'M':case 'N':case 'O':case '6':
                    d = '6';
                    break;
                    case 'P':case 'Q':case 'R':case 'S':case '7':
                    d='7';
                    break;
                    case 'T':case 'U':case 'V':case '8':
                    d='8';
                    break;
                    case 'W':case 'X':case 'Y':case 'Z':case '9':
                    d='9';
                    break;
                case'1':
                    d='1';
                    break;
                case '0':
                    d='0';
                    break;
                default:
                    return 4;
                }
            return 0;
        }
        //
   // Main(): Declares seven character variables and passes these to the following methods by reference:
        //ProcessInput(): gets user input and performs the conversion
       // ShowResults(): displays the results
    //GetInput(): Gets seven characters from the user and stores them into the seven variables Main() has passed by reference.
    //ProcessInput(): Calls ToDigit() for each, passing each character variable by reference, and returns one of these codes to Main() by value:
      //  0 if there were no input errors
        //-1 if there were input errors

//Input errors include the following:

  //      The first character is 0 (seven-digit phone numbers can't start with 0).
    //    The first three characters are "555" (no phone numbers start with 555).
      //  Any character is not a digit or an uppercase or lowercase letter.
    //ToDigit(): Converts a character (passed by reference) to its corresponding digit per the table above, and returns one of these codes to ProcessInput() by value:
      //  0 if the character is valid (a digit or uppercase or lowercase letter)
        //-1 if the character is not valid
    //ShowResults(): Writes converted telephone number to the screen, inserting a dash (-) between the third and fourth digits, and accepts the seven character variables from Main() by reference.

    }
}
