using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Team
    {
        List<Programmer> programmers;

        public Team()
        {
            programmers = new List<Programmer>();
        }

        public void AddProgrammer(Programmer p)
        {
            programmers.Add(p);
        }

        public void PrintAllTeamMembers()
        {
            foreach (Programmer p in programmers)
            {
                p.Print();
            }
        }
    }
}
