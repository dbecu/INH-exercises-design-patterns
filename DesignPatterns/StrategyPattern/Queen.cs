using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Queen : Character
    {
        public Queen() : base(new KnifeBehaviour()) { }
    }
}
