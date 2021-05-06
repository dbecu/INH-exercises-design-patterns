using System;
using System.IO;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();
        }

        void Start()
        {

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            string filename = name + ".txt";


            if (!File.Exists(filename))
            {
                Console.WriteLine($"Welcome {name}!");
                WritePerson(ReadPerson(), filename);

            }
            else
            {
                Console.WriteLine($"Nice to see you again, {name}");
                Console.WriteLine("We have the following information about you: ");
                DisplayPerson(ReadPerson(filename));
            }
            


        }
        public Person ReadPerson()
        {
            Person newPerson = new Person();
            Console.Write("Enter your name: ");
            newPerson.name = Console.ReadLine();

            Console.Write("Enter your city: ");
            newPerson.city = Console.ReadLine();

            Console.Write("Enter your age: ");
            newPerson.age = int.Parse(Console.ReadLine());

            return newPerson;
        }

        public void DisplayPerson(Person p) //redundant??
        {
            Console.WriteLine("{0, -5} : {1}", "Name", p.name);
            Console.WriteLine("{0, -5} : {1}", "City", p.city);
            Console.WriteLine("{0, -5} : {1}", "Age", p.age);
        }

        public Person ReadPerson(string filename)
        {
            Person personInFile = new Person();

            if (File.Exists(filename))
            {

                StreamReader reader = new StreamReader(filename);       //opening

                personInFile.name = reader.ReadLine();
                personInFile.city = reader.ReadLine();
                personInFile.age = int.Parse(reader.ReadLine());

                //redundant code!!!
                reader.Close();     //closing, has to!

            }

            return personInFile;
        }

        //Creates a file and writes to created file
        public void WritePerson(Person p, string filename)
        {
            StreamWriter writer = new StreamWriter(filename);       //opening

            writer.WriteLine(p.name);
            writer.WriteLine(p.city);
            writer.WriteLine(p.age);

            writer.Close();     //closing, has to!

            Console.WriteLine("Your data is written to a file.");
        }

    }
}
