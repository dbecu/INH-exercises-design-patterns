using System;

namespace Assignment2
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
            Person p0;
            p0.FirstName = "Dewi";
            p0.LastName = "Becu";
            p0.Age = 19;
            p0.City = "Lisse";
            p0.Gender = GenderType.Female;

            PrintPerson(p0);

            Person p1 = ReadPerson();
            PrintPerson(p1);

            Console.WriteLine("\nAssignment 2g below:");

            const int ARRAYSIZE = 3;
            Person[] personArray = new Person[ARRAYSIZE];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < personArray.Length; j++)
                {
                    if (i == 0)
                    {
                        personArray[j] = ReadPerson();
                        Console.WriteLine();
                    }

                    else
                    {
                        PrintPerson(personArray[j]);
                        Console.WriteLine();
                    }
                        
                }
            }

            Console.WriteLine("\nAssignment 2h below:");
            CelebrateBirthday(ref p0);
            PrintPerson(p0);

            Console.ReadKey();
        }

        int ReadInt(string question)
        {
            Console.Write(question);
            return int.Parse(Console.ReadLine());
        }


        string ReadString(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }


        Person ReadPerson()
        {

            Person person;
            person.FirstName = ReadString("Enter first name: ");
            person.LastName = ReadString("Enter last name: ");
            person.Age = ReadInt("Enter age: ");
            person.Gender = ReadGender("Enter gender (m/f): ");
            person.City = ReadString("Enter city: ");

            return person;

        }
        void PrintPerson(Person p)
        {
            Console.WriteLine("{0} {1} ({2})\n{3} years old, {4}", 
                p.FirstName, p.LastName, Char.ToLower(p.Gender.ToString()[0]), p.Age, p.City);
        }

        GenderType ReadGender(string question)
        {
            while (true)
            {
                Console.Write(question);
                string gender = Console.ReadLine();
                if (gender.Equals("m"))
                    return GenderType.Male;
                if (gender.Equals("f"))
                    return GenderType.Female;

                Console.WriteLine("Please insert f or m");
            }
        }

        void PrintGender(GenderType gender)
        {
            if (gender.Equals(GenderType.Male))
                Console.WriteLine("m");
            else
                Console.WriteLine("f");
        }

        //gotta be ref or else if it's passed by value, the changed value is just gonna change
        void CelebrateBirthday(ref Person p)
        {
            p.Age++;
        }

    }
}
