using System;
using System.Collections.Generic;
using System.Text;
using Builder_Design_Pattern.Inventory;

namespace Builder_Design_Pattern.CharacterInfo
{
    public class CharacterBuilder : ICharacterBuilder
    {
        public string CharacterName { set; get; }
        public string CharacterClass { set; get; }
        public int CharacterLevel { set; get; }
        public Armor ArmorWearing { get; set; }
        public Weapons Weapon { set; get; }

        public Character Build()
        {
            return new Character(CharacterName, CharacterClass, CharacterLevel, Weapon, ArmorWearing);
        }

        public CharacterBuilder AddArmor(Armor armor)
        {
            ArmorWearing = armor;
            return this;
        }

        public CharacterBuilder AddClassType(string classType)
        {
            CharacterClass = classType;
            return this;
        }

        public CharacterBuilder AddLevel(int level)
        {
            CharacterLevel = level;
            return this;
        }

        public CharacterBuilder AddName(string name)
        {
            CharacterName = name;
            return this;
        }

        public CharacterBuilder AddWeapon(Weapons weapons)
        {
            Weapon = weapons;
            return this;
        }
    }
}
