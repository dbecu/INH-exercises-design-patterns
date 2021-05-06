using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete context
    class Troll : Character
    {
        public Troll() : base(new AxeBehaviour()) { }
    }
}
