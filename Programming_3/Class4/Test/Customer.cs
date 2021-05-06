using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Customer
    {
        private int id;

        public string EmailAddress
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string LastName
        {
            get; set;
        }

        public Customer(int id, string firstName, string lastName, string emailAddress)
        {
            this.id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;

        }

        public override string ToString()
        {
            return String.Format($"{Id}. {FullName} ({EmailAddress})");
        }

    }
}
