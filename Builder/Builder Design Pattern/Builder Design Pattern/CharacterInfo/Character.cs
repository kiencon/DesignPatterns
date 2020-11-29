using System;
using System.Collections.Generic;
using System.Text;
using Builder_Design_Pattern.Inventory;

namespace Builder_Design_Pattern.CharacterInfo
{
    public class Character
    {
        public Character() {
            CharacterName = "";
            CharacterClass = "";
            CharacterLevel = 0;
            Weapon = new Weapons("");
            ArmorWearing = new Armor("", 0);
        }
        public Character(string charName, string charClass, int charLevel, Weapons weaponName, Armor armor)
        {
            CharacterName = charName;
            CharacterClass = charClass;
            CharacterLevel = charLevel;
            Weapon = weaponName;
            ArmorWearing = armor;
        }
        public string GetCharacterProfile()
        {
            var profile = "";
            profile += $"Name:  \t {CharacterName}\n";
            profile += $"Level: \t {CharacterLevel}\n";
            profile += $"Class: \t {CharacterClass}\n";
            profile += $"Weapon:\t {Weapon.GetWeapons()}\n";
            profile += $"Armor: \t {ArmorWearing.GetArmor()}\n";
            return profile;
        }
        public string CharacterName { set; get; }
        public string CharacterClass { set; get; }
        public int CharacterLevel { set; get; }
        public Armor ArmorWearing { get; set; }
        public Weapons Weapon { set; get; }
    }
}
