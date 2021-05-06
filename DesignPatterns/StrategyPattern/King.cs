using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete context
    class King : Character
    {
        public King() : base(new BowAndArrowBehaviour()) { }

    }
}
