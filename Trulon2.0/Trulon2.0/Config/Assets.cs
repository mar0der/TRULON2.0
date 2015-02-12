#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;
#endregion

namespace GameEngine
{
    public static class Assets
    {
        //Barbarian base constants
        public static readonly string[] BarbarianImages = new string[9]
        {
            "Barbarian/None.png",
            "Barbarian/North.png",
            "Barbarian/NorthEast.png",
            "Barbarian/East.png",
            "Barbarian/SouthEast.png",
            "Barbarian/South.png",
            "Barbarian/SouthWest.png",
            "Barbarian/West.png",
            "Barbarian/NorthWest.png"
        };

        //Paladin base constants
        public static readonly string[] PaladinImages = new string[9]
        {
            "Paladin/None.png",
            "Paladin/North.png",
            "Paladin/NorthEast.png",
            "Paladin/East.png",
            "Paladin/SouthEast.png",
            "Paladin/South.png",
            "Paladin/SouthWest.png",
            "Paladin/West.png",
            "Paladin/NorthWest.png"
        };

        //Goblin base constants
        public static readonly string[] GoblinImages = new string[9]
        {
            "Goblin/None.png",
            "Goblin/North.png",
            "Goblin/NorthEast.png",
            "Goblin/East.png",
            "Goblin/SouthEast.png",
            "Goblin/South.png",
            "Goblin/SouthWest.png",
            "Goblin/West.png",
            "Goblin/NorthWest.png"
        };

        //Orc base constants
        public static readonly string[] OrcImages = new string[9]
        {
            "Orc/None.png",
            "Orc/North.png",
            "Orc/NorthEast.png",
            "Orc/East.png",
            "Orc/SouthEast.png",
            "Orc/South.png",
            "Orc/SouthWest.png",
            "Orc/West.png",
            "Orc/NorthWest.png"
        };

        //Troll base constants
        public static readonly string[] TrollImages = new string[9]
        {
            "Troll/None.png",
            "Troll/North.png",
            "Troll/NorthEast.png",
            "Troll/East.png",
            "Troll/SouthEast.png",
            "Troll/South.png",
            "Troll/SouthWest.png",
            "Troll/West.png",
            "Troll/NorthWest.png"
        };
        //NPCs
        //Vendor
        public static readonly string[] Vendor = new string[1]
        {
            "NPCs/Vendor.png"
        };

        //Trainer
        public static readonly string[] Trainer = new string[1]
        {
            "NPCs/Trainer.png"
        };

        //Items
        //Boots
        public static readonly string Boots = "Items/Boots.png";

        //Helmet
        public static readonly string Helmet = "Items/Helmet.png";
        //Pants
        public static readonly string Pants = "Items/Pants.png";
        //Vest
        public static readonly string Vest = "Items/Vest.png";
        //Hand items
        //Axe
        public static readonly string Axe = "Items/Axe.png";
        //Shield
        public static readonly string Shield = "Items/Shield.png";
        //Sword
        public static readonly string Sword = "Items/Sword.png";
        //Timeoutable Items
        //DamagePotion
        public static readonly string DamagePotion = "Items/DamagePotion.png";
        //HealthPotion
        private static readonly string HealthPotion = "Items/HealthPotion";
    }
}
