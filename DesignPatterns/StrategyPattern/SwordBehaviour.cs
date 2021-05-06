using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete strategy
    class SwordBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword");
        }
    }
}
