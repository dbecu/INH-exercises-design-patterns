using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    //class Person
    //{
    //}

    public struct Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string City;
        public GenderType Gender;
    }

    public enum GenderType
    {
        Male, Female
    }

}
