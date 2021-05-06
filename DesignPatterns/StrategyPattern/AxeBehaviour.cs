using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete strategy
    class AxeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe");
        }
    }
}
