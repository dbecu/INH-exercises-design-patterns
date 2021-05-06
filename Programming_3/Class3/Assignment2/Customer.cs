using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    class Customer
    {
        private string name;
        private DateTime dateOfBirth;
        private DateTime registrationDate;
        
        public string Name
        {
            get { return name;  }
            set 
            { 
                if (value.Length != 0)
                    name = value;
            }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set 
            {
                DateTime date = new DateTime(1900, 1, 1);
                if(value.Date < DateTime.Now && value.Date > date)
                {
                    dateOfBirth = value;
                }
            }
        }   

        public int Age
        {
            get 
            {
                return (int)DateTime.Now.Subtract(dateOfBirth).TotalDays / 365;
            }
        }

        public bool Discount
        { 
            get
            {
                return DateTime.Today > registrationDate.AddDays(365);
            }
        }


        public DateTime RegistrationDate
        {
            get { return registrationDate; }
            set { registrationDate = value; }
        }

        public Customer(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            this.registrationDate = DateTime.Now;
        }

        public void PrintCustomer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Name);
            Console.ResetColor();
            Console.WriteLine($"date of birth: {dateOfBirth.Day}/{dateOfBirth.Month}/{dateOfBirth.Year}\n" +
                                    $"age: {Age}\n" +
                                    $"date of registration: {RegistrationDate}\n" +
                                    $"discount: {Discount}\n");
        }


    }
}
