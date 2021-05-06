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
            get; set;
        }

        public int Id
        {
            get; set;
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
            return base.ToString();
        }

    }
}
