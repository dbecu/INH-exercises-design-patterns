using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //Concrete strategy
    class KnifeBehaviour : IWeaponBehaviour
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife");
        }
    }
}
