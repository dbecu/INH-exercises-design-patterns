using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete strategy
    class BowAndArrowBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow");
        }
    }
}
