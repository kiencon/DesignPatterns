using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Pattern.Inventory
{
    public class Weapons
    {
        public Weapons(string _name)
        {
            Name = _name;
        }
        public string Name { get; set; }
        public string GetWeapons() => Name;
    }
}
