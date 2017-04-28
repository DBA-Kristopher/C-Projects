using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSys
{
    abstract class EmPloye
    {
        //Const variables 
        //------------------------------------------------------------------------------------------------------------------------------------
        
        private const int MIN_DEPENDENTS = 0;
        private const int MAX_DENPENDENTS = 10;
        private const double MIN_SALARY = 20000;
        private const double MAX_SALARY = 100000;
        private const string DEFAULT_NAME = "not given";
        private const char DEFAULT_GENDER = 'U';
        private const string DEFAULT_TYPE = "Unknown";
        // Data members
        //------------------------------------------------------------------------------------------------------------------------------------

        protected string firstName = DEFAULT_NAME;
        protected string lastName = DEFAULT_NAME;
        protected char gender = DEFAULT_GENDER;
        protected int dependents = MIN_DEPENDENTS;
        protected double annualSalary = MIN_SALARY;
        protected Benefits theBenefits;
        protected static int numEmployees = 0;
        protected string employeeType= DEFAULT_TYPE;

        //Default Constructors
        //------------------------------------------------------------------------------------------------------------------------------------
        public EmPloye()
        {
            theBenefits = new Benefits();
            numEmployees++;
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        
        public EmPloye(string employeeType)
            : this()
        {
            EmployeeType = employeeType;
        }

        //------------------------------------------------------------------------------------------------------------------------------------
        public EmPloye(string employeeType, string firstName, string lastName, char gender, int dependents, double salary, Benefits theBenefits)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Dependents = dependents;
            AnnualSalary = salary;
            TheBenefits = theBenefits;
            numEmployees++;

        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //Calcuate Net pay

        public abstract double CalculateNetPay();

        //------------------------------------------------------------------------------------------------------------------------------------
        //Calcuate weekly pay

        #region Methods 
        public virtual double CalculateWeeklyPay()
        {
            double weeklypay = 0;
            weeklypay = annualSalary / 52;

            return weeklypay;
        }
        public virtual double CalculateWeeklyPay(double money)
        {

            double weeklypay = 0;
            weeklypay = money / 52;

            return weeklypay;
        }
        //------------------------------------------------------------------------------------------------------------------------------------
        //ToString method to display all employee information

        public virtual String ToString()
        {
            string results;
            results =
                "Employee Type: " + employeeType + "\n" +
                "Name: " + firstName + " " + lastName + "\n" +
                "Gender:  " + gender + "\n" +
                "Dependents: " + dependents + "\n" +
                "Annual Salary: " + annualSalary.ToString("C2") + "\n" +
                "Weekly Pay: " + CalculateWeeklyPay().ToString("C2") + "\n" +
                "Weekly Net Pay: " + CalculateNetPay().ToString("C2") + "\n" +
                TheBenefits.ToString();



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
        public Benefits TheBenefits
        {
            get { return theBenefits; }
            set
            {
                if (value == null)
                    theBenefits = new Benefits();
                else
                    theBenefits = value;
            }
        }
        public string EmployeeType
    {
        get
        {
            return employeeType;
    }
        set
        {
            if (String.IsNullOrEmpty(value))
                employeeType = DEFAULT_TYPE;
            else
                employeeType = value;

        }
    
    }
        #endregion
    }
}
