using System;

namespace Assignment1
{
    class Program //view class diagram??
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Team team = new Team();

            team.AddProgrammer(new Programmer("Arogant", Speciality.Csharp));
            team.AddProgrammer(new Programmer("Bologne", Speciality.HTML));
            team.AddProgrammer(new Programmer("Chapeau", Speciality.Java));
            team.AddProgrammer(new Programmer("Drapeur", Speciality.PHP));

            team.PrintAllTeamMembers();
        }
    }
}
