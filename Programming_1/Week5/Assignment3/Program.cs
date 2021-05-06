using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter course name: ");
            string course = Console.ReadLine();
            Console.Write("Enter number of students: ");
            int numStudents = int.Parse(Console.ReadLine());
            string[] names = new string[numStudents];
            double[] grades = new double[numStudents];
            double avg = 0;

            Console.WriteLine();

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write("Enter name of student {0}: ", i + 1);
                names[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0; i < numStudents; i++)
            {
                Console.Write("Enter grade of {0}: ", names[i]);
                grades[i] = double.Parse(Console.ReadLine());
                avg += grades[i];
            }

            Console.WriteLine();
            Console.WriteLine("Average grade: {0}", (avg / numStudents).ToString("0.00"));

            double highest = -1;

            for (int i = 0; i < numStudents; i++)
            {
                if (grades[i] > highest)
                    highest = grades[i];
            }

            int index = Array.IndexOf(grades, highest);

            Console.WriteLine("Student {0} has the highest grade with {1} points", names[index], grades[index].ToString("0.00"));

            Console.WriteLine();

            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine("Grade for student {0} (course {1}) is: {2}", 
                    names[i], course, grades[i].ToString("0.0"));

            }

            Console.ReadKey();

        }
    }
}
