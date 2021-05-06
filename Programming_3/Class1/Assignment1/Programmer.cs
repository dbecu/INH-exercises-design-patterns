using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Programmer
    {

        string name;
        Speciality speciality;

        public Programmer(string name, Speciality speciality)
        {
            this.name = name;
            this.speciality = speciality;
        }

        public Programmer(string name)      //this correct?
            : this(name, Speciality.Unknown) { }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Speciality: {speciality}");
        }

    }
}
