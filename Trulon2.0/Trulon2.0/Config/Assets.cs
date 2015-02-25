using System.Web.Configuration;

namespace Trulon.Config
{
    public static class Assets
    {
        //Maps
        public static readonly string[] Maps = new string[Config.NumberOfLevels]
        {
            "Images/MapImages/TrulonHomeMap.jpg",
            "Images/MapImages/Goblin.jpg",
            "Images/MapImages/Robo.jpg",
            "Images/MapImages/Ogre.jpg",
            "Images/MapImages/Boss.jpg"
        };
        //Barbarian base constants
        public static readonly string[] BarbarianImages = new string[]
        {
            "Images/Barbarian/Barbarian-Walking1-256x192.png",
            "Images/Barbarian/Barbarian-Walking2.png",
            "Images/Barbarian/Barbarian-Walking3.png",
            "Images/Barbarian/Barbarian-Walking4.png",
            "Images/Barbarian/Barbarian-Walking1Left.png",
            "Images/Barbarian/Barbarian-Walking2Left.png",
            "Images/Barbarian/Barbarian-Walking3Left.png",
            "Images/Barbarian/Barbarian-Walking4Left.png",
            "Images/Barbarian/Barbarian-RightAttacking1.png",
            "Images/Barbarian/Barbarian-RightAttacking2.png",
            "Images/Barbarian/Barbarian-RightAttacking3.png",
            "Images/Barbarian/Barbarian-RightAttacking4.png",
            "Images/Barbarian/Barbarian-LeftAttacking1.png",
            "Images/Barbarian/Barbarian-LeftAttacking2.png",
            "Images/Barbarian/Barbarian-LeftAttacking3.png",
            "Images/Barbarian/Barbarian-LeftAttacking4.png"
        };

        //Paladin base constants
        public static readonly string[] PaladinImages = new string[9]
        {
            "Images/Paladin/None.png",
            "Images/Paladin/North.png",
            "Images/Paladin/NorthEast.png",
            "Images/Paladin/East.png",
            "Images/Paladin/SouthEast.png",
            "Images/Paladin/South.png",
            "Images/Paladin/SouthWest.png",
            "Images/Paladin/West.png",
            "Images/Paladin/NorthWest.png"
        };

        //Goblin base constants
        public static readonly string[] GoblinImages = new string[16]
        {
            "Images/Goblin/goblinMove1.png",
            "Images/Goblin/goblinMove2.png",
            "Images/Goblin/goblinMove3.png",
            "Images/Goblin/goblinMove4.png",
            "Images/Goblin/goblinMove1Right.png",
            "Images/Goblin/goblinMove2Right.png",
            "Images/Goblin/goblinMove3Right.png",
            "Images/Goblin/goblinMove4Right.png",
            "Images/Goblin/goblinAttack1.png",
            "Images/Goblin/goblinAttack2.png",
            "Images/Goblin/goblinAttack3.png",
            "Images/Goblin/goblinAttack4.png",
            "Images/Goblin/goblinAttack1Right.png",
            "Images/Goblin/goblinAttack2Right.png",
            "Images/Goblin/goblinAttack3Right.png",
            "Images/Goblin/goblinAttack4Right.png"
        };

        //Robo base constants
        public static readonly string[] OgreImages = new string[16]
        {
            "Images/Ogre/OgreMove1.png",
            "Images/Ogre/OgreMove2.png",
            "Images/Ogre/OgreMove3.png",
            "Images/Ogre/OgreMove4.png",
            "Images/Ogre/OgreMove1Left.png",
            "Images/Ogre/OgreMove2Left.png",
            "Images/Ogre/OgreMove3Left.png",
            "Images/Ogre/OgreMove4Left.png",
            "Images/Ogre/OgreAttack1.png",
            "Images/Ogre/OgreAttack2.png",
            "Images/Ogre/OgreAttack3.png",
            "Images/Ogre/OgreAttack4.png",
            "Images/Ogre/OgreAttack1Left.png",
            "Images/Ogre/OgreAttack2Left.png",
            "Images/Ogre/OgreAttack3Left.png",
            "Images/Ogre/OgreAttack4Left.png"
        };

        //Troll base constants
        public static readonly string[] RoboImages = new string[16]
        {
            "Images/Robo/RoboMove1.png",
            "Images/Robo/RoboMove2.png",
            "Images/Robo/RoboMove3.png",
            "Images/Robo/RoboMove4.png",
            "Images/Robo/RoboMove1Left.png",
            "Images/Robo/RoboMove2Left.png",
            "Images/Robo/RoboMove3Left.png",
            "Images/Robo/RoboMove4Left.png",
            "Images/Robo/RoboAttack1.png",
            "Images/Robo/RoboAttack2.png",
            "Images/Robo/RoboAttack3.png",
            "Images/Robo/RoboAttack4.png",
            "Images/Robo/RoboAttack1Left.png",
            "Images/Robo/RoboAttack2Left.png",
            "Images/Robo/RoboAttack3Left.png",
            "Images/Robo/RoboAttack4Left.png"
        };

        //NPCs
        //Vendor
        public static readonly string[] Vendor = new string[1]
        {
            "Images/NPCs/Vendor.png"
        };

        //Trainer
        public static readonly string[] Trainer = new string[1]
        {
            "Images/NPCs/Trainer.png"
        };

        //Items
        //Boots
        public static readonly string Boots = "Images/Items/Boots.png";
        //Helmet
        public static readonly string Helmet = "Images/Items/Helmet.png";
        //Pants
        public static readonly string Pants = "Images/Items/Pants.png";
        //Vest
        public static readonly string Vest = "Images/Items/Vest.png";

        //Hand items
        //Axe
        public static readonly string Axe = "Images/Items/Axe.png";
        //Shield
        public static readonly string Shield = "Images/Items/Shield.png";
        //Sword
        public static readonly string Sword = "Images/Items/Sword.png";

        //Timeoutable Items
        //DamagePotion
        public static readonly string DamagePotion = "Images/Items/DamagePotion.png";
        //HealthPotion
        public static readonly string HealthPotion = "Images/Items/HealthPotion.png";
        //DefensePotion
        public static readonly string DefensePotion = "Images/Items/DefensePotion.png";
        //SpeedPotion
        public static readonly string SpeedPotion = "Images/Items/SpeedPotion.png";
        //AttackRadiusPotion
        public static readonly string AttackRangePotion = "Images/Items/AttackRangePotion.png";


        //Equipment empty slots
        public static readonly string EmptyHead = "Images/EmptyEquipment/EmptyHead.png";
        public static readonly string EmptyLeftHand = "Images/EmptyEquipment/EmptyLeftHand.png";
        public static readonly string EmptyRightHand = "Images/EmptyEquipment/EmptyRightHand.png";
        public static readonly string EmptyBody = "Images/EmptyEquipment/EmptyBody.png";
        public static readonly string EmptyFeet = "Images/EmptyEquipment/EmptyFeet.png";

        //HealthBar
        public static readonly string HealthBar = "Images/HealthBar.png";
    }
}
