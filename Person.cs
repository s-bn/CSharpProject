using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculator
{
    class Person
    {
        private int employeeID;
        private string firstName;
        private string surname;
        private string gender;
        private string email;

        public Person()
        {
        }

        public Person(int employeeID, string firstName, string surname, string gender, string email)
        {
            this.employeeID = employeeID;
            this.firstName = firstName;
            this.surname = surname;
            this.gender = gender;
            this.email = email;
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
            }
        }


        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
               
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }

    class Employee : Person
    {
        private string department;
        private double hourlyRate;

        public Employee()
        {
        }

        public Employee(string department, double hourlyRate)
        {
            this.department = department;
            this.hourlyRate = hourlyRate;
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }
    }

    class Contractor : Employee
    {
        private double hours;

        public Contractor()
        {
        }

        public Contractor(int employeeID, double hours)
        {
            this.hours = hours;
        }

        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = Hours;
            }
        }
    }

}
