using System;
using Builder_Design_Pattern.Inventory;
using Builder_Design_Pattern.CharacterInfo;

namespace Builder_Design_Pattern
{
    class Program
    {
        private const string weaponName = "Sword";

        static void Main(string[] args)
        {
            var hero = new Character(
                    "Ryan",
                    "Warrior",
                    30,
                    new Weapons(weaponName),
                    new Armor("Silver Armor", 18)
                );


            var assassin = new CharacterBuilder()
                                .AddName("Thanh")
                                .AddArmor(new Armor("Steel Armor", 20))
                                .AddWeapon(new Weapons("Knift"))
                                .AddClassType("Assassin")
                                .AddLevel(50)
                                .Build();


            var villainBoss = new CharacterBuilder()
                                .AddLevel(100)
                                .AddArmor(new Armor("Invincible Armor", 500))
                                .AddWeapon(new Weapons("Magic Staff"))
                                .AddName("Dark Lord")
                                .AddClassType("Demon")
                                .Build();

            Console.WriteLine("===== Before using Builder pattern =====");
            Console.WriteLine(hero.GetCharacterProfile());

            Console.WriteLine("===== After using Builder pattern ======");
            Console.WriteLine(assassin.GetCharacterProfile());
            Console.WriteLine("========================================");
            Console.WriteLine(villainBoss.GetCharacterProfile());
            Console.WriteLine("========================================");
        }
    }
}
