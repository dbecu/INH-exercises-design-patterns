using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete context
    class Knight : Character
    {
        public Knight() : base(new SwordBehaviour()) { }
    }
}
