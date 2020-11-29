using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern.Inventory
{
    public class Armor
    {
        public Armor(string _name, int _level)
        {
            Name = _name;
            Level = _level;
        }
        public string Name { get; set; }

        public int Level { get; set; }
        public string GetArmor() => $"{Name} level {Level}";
    }
}
