using System;
using System.Collections.Generic;

namespace Assignment1
{
    public enum PracticalGrade
    {
        None, Absent, Insufficient, Sufficient, Good
    }

    public class Course
    {
        public string Name;
        public int Grade;
        public PracticalGrade Practical;

        public bool Passed()
        {
            return (this.Grade >= 55 && this.Practical >= PracticalGrade.Sufficient);      
        }
        public bool CumLaude()
        {
            return (this.Grade >= 80 && this.Practical >= PracticalGrade.Good);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Start();

        }

        void Start()
        {
            List<Course> report = ReadReport(3);
            DisplayReport(report);
            Console.ReadKey();

        }

        //the copied methods
        int ReadInt(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            return int.Parse(Console.ReadLine());
        }

        int ReadInt(string question, int min, int max)
        {
            int num;

            do
            {
                num = ReadInt(question);

            } while (!(num >= min && num <= max));

            return num;
        }

        string ReadString(string question)
        {
            Console.Write(question);
            Console.ForegroundColor = ConsoleColor.Green;
            return Console.ReadLine();
        }
        //end copied methods

        
        PracticalGrade ReadPracticalGrade(String question)
        {
            for (int i = 0; i <= (int)PracticalGrade.Good; i++)
                Console.Write($"{i}. {(PracticalGrade)i}  ");
            Console.WriteLine();

            int pGrade = ReadInt(question);
            Console.ForegroundColor = ConsoleColor.Green;
            return (PracticalGrade)pGrade;
        }

        void DisplayPracticalGrade(PracticalGrade practical)
        {
            Console.Write(practical);
        }

        Course ReadCourse(string question)
        {
            Course returnCourseObject = new Course();

            Console.WriteLine(question);

            string courseName = ReadString("Name of the course: ");
            Console.ResetColor();

            int courseGrade = ReadInt($"Grade for {courseName}: ");
            Console.ResetColor();

            PracticalGrade pGrade = ReadPracticalGrade($"Practical Grades for {courseName}: ");
            Console.ResetColor();

            returnCourseObject.Name = courseName;
            returnCourseObject.Grade = courseGrade;
            returnCourseObject.Practical = pGrade;

            Console.WriteLine();

            return returnCourseObject;

        }
            
        void DisplayCourse(Course course)
        {
            Console.Write(
                $"{course.Name,-3} : {course.Grade,-3} ");
            DisplayPracticalGrade(course.Practical);

            Console.WriteLine();
        }

        List<Course> ReadReport(int nrOfCourses)
        {
            List<Course> courseList = new List<Course>();

            for (int i = 0; i < nrOfCourses; i++)
                courseList.Add(ReadCourse("Enter a course"));

            return courseList;
        }

        void DisplayReport(List<Course> report)
        {
            bool graduate = true;
            bool cumlaude = true;
            int resits = 0;
            foreach (Course course in report)
            {
                DisplayCourse(course);
                if (!course.Passed())
                {
                    graduate = false;
                    resits++;
                }

                if (!course.CumLaude())
                    cumlaude = false;
                    
            }

            string message;

            if (graduate)
            {
                message = "Congrats! You passed!";
                if (cumlaude)
                    message += " \nAnd you got cumlaude, nice!";
            }
            else
                message = String.Format($"Too bad, you did not graduate, you got {resits} retake(s)");

            Console.WriteLine(message);
            
        }


    }
}
