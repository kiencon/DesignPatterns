using System;
using System.Collections.Generic;
using System.Text;
using Builder_Design_Pattern.Inventory;

namespace Builder_Design_Pattern.CharacterInfo
{
    interface ICharacterBuilder
    {
        //public void AddName(string name);
        //public void AddLevel(int level);
        //public void AddClassType(string classType);
        //public void AddWeapon(Weapons weapons);
        //public void AddArmor(Armor armor);

        public CharacterBuilder AddName(string name);
        public CharacterBuilder AddLevel(int level);
        public CharacterBuilder AddClassType(string classType);
        public CharacterBuilder AddArmor(Armor armor);
        public Character Build();
    }
}
