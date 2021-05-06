using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    //The Context
    abstract class Character
    {
        public IWeaponBehaviour Weapon { get; set; }        //Property so it wont hurt other codea

        public Character(IWeaponBehaviour weapon) 
        {
            Weapon = weapon;
            //Weapon = new SwordBehaviour();      //default
        }

        //One-to-one
        //Each character needs to fight
        public void Fight()
        {
            Weapon.UseWeapon();
        }
    }
}
