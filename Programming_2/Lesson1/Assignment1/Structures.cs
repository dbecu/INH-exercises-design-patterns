using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Structures
    {

        //Basically class with predefines attributes. A class with no methods basically!
        //Struct doesn't create an object?? Can be an object, but doesn't have to be
        //Definition: an  object is created when 'new' is used
        //structs are passed by value, unlike classes which are passed by reference
        struct Student
        {
            public string Name;
            public int Number;
            public DateTime DateOfBirth;
            public float[] Grades;
            public string City;
        }

        public static void notMain(String[] args)
        {
            //Student student0 = new Student("Dewi", 656552, new DateTime(2000, 11, 7), new float[10], "Lisse");
            //Apparently can't do the above

            Student student1;
            student1.Name = "Dewi";
            student1.Number = 656552;
            student1.DateOfBirth = new DateTime(2000, 11, 7);
            student1.Grades = new float[10];
            student1.City = "Lisse";
        }
    }
}
