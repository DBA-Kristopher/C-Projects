using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSys
{
    class EmPloye
    {
        //Const variables 
        //------------------------------------------------------------------------------------------------------------------------------------
        
        private const int MIN_DEPENDENTS = 0;
        private const int MAX_DENPENDENTS = 10;
        private const double MIN_SALARY = 20000;
        private const double MAX_SALARY = 100000;
        private const string DEFAULT_NAME = "not given";
        private const char DEFAULT_GENDER = 'U';

        // Data members
        //------------------------------------------------------------------------------------------------------------------------------------
        
        private string firstName = DEFAULT_NAME;
        private string lastName = DEFAULT_NAME;
        private char gender = DEFAULT_GENDER;
        private int dependents = MIN_DEPENDENTS;
        private double annualSalary = MIN_SALARY;
        
        private static int numEmployees = 0;

        //Default Constructors
        //------------------------------------------------------------------------------------------------------------------------------------
        public EmPloye()
        {
            numEmployees++;
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        public EmPloye(string firstName, string lastName, char gender, int dependents, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Dependents = dependents;
            AnnualSalary = salary;
            numEmployees++;
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //Calcuate weekly pay

        #region Methods 
        public double CalculateWeeklyPay()
        {
            double weeklypay = 0;
            weeklypay = annualSalary / 52;

            return weeklypay;
        }
        public double CalculateWeeklyPay(double money)
        {

            double weeklypay = 0;
            weeklypay = money / 52;

            return weeklypay;
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //ToString method to display all employee information

        public override String ToString()
        {
            string results;
            results =
                "Name: " + firstName + " " + lastName + "\n" +
                "Gender:  " + gender + "\n" +
                "Dependents: " + dependents + "\n" +
                "Annual Salary: " + annualSalary.ToString("C2") + "\n" +
                "Weekly Pay: " + CalculateWeeklyPay().ToString("C2");



            return results;
        }
        #endregion 
        //-------------------------------------------------------------------------------------------------------------------------------------
      
        #region Properties 
        //First name property
        public string FirstName
        {
            get { return firstName; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                    firstName = DEFAULT_NAME;
                else
                    firstName = value;
            }
        }
        //Last name property
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    lastName = DEFAULT_NAME;
                else
                    lastName = value;
            }
        }
        //Gender Property 
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'm' || value == 'M' || value == 'F' || value == 'f')
                    gender = value;
                else
                    gender = DEFAULT_GENDER;

            }
        }
        public int Dependents
        {
            get { return dependents; }
            set
            {
                if (value <= MIN_DEPENDENTS)
                    dependents = MIN_DEPENDENTS;
                else if (value >= MAX_DENPENDENTS)
                    dependents = MAX_DENPENDENTS;
                else
                    dependents = value;

            }

        }
        public double AnnualSalary
        {
            get { return annualSalary; }
            set
            {
                if (value > MIN_SALARY && value < MAX_SALARY)
                    annualSalary = value;
                else if (value >= MAX_SALARY)
                    annualSalary = MAX_SALARY;
                else
                    annualSalary = MIN_SALARY;
            }
        }
        public static int NumEmployees
        {
            get { return numEmployees; }
        }

        #endregion
    }
}
