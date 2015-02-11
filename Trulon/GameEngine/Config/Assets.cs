using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GameEngine
{
    public static class Assets
    {
         private static Uri _baseUri = new Uri(@"pack://application:,,,/Ressoruces/Images/");

        //Barbarian base constants
        public static readonly Image[] BarbarianImages = new Image[9]
        {
            CreateImageFromSource("Barbarian/None.png"),
            CreateImageFromSource("Barbarian/North.png"),
            CreateImageFromSource("Barbarian/NorthEast.png"),
            CreateImageFromSource("Barbarian/East.png"),
            CreateImageFromSource("Barbarian/SouthEast.png"),
            CreateImageFromSource("Barbarian/South.png"),
            CreateImageFromSource("Barbarian/SouthWest.png"),
            CreateImageFromSource("Barbarian/West.png"),
            CreateImageFromSource("Barbarian/NorthWest.png")
        };

        //Paladin base constants
        public static readonly Image[] PaladinImages = new Image[9]
        {
            CreateImageFromSource("Paladin/None.png"),
            CreateImageFromSource("Paladin/North.png"),
            CreateImageFromSource("Paladin/NorthEast.png"),
            CreateImageFromSource("Paladin/East.png"),
            CreateImageFromSource("Paladin/SouthEast.png"),
            CreateImageFromSource("Paladin/South.png"),
            CreateImageFromSource("Paladin/SouthWest.png"),
            CreateImageFromSource("Paladin/West.png"),
            CreateImageFromSource("Paladin/NorthWest.png")
        };

        //Goblin base constants
        public static readonly Image[] GoblinImages = new Image[9]
        {
            CreateImageFromSource("Goblin/None.png"),
            CreateImageFromSource("Goblin/North.png"),
            CreateImageFromSource("Goblin/NorthEast.png"),
            CreateImageFromSource("Goblin/East.png"),
            CreateImageFromSource("Goblin/SouthEast.png"),
            CreateImageFromSource("Goblin/South.png"),
            CreateImageFromSource("Goblin/SouthWest.png"),
            CreateImageFromSource("Goblin/West.png"),
            CreateImageFromSource("Goblin/NorthWest.png")
        };

        //Orc base constants
        public static readonly Image[] OrcImages = new Image[9]
        {
            CreateImageFromSource("Orc/None.png"),
            CreateImageFromSource("Orc/North.png"),
            CreateImageFromSource("Orc/NorthEast.png"),
            CreateImageFromSource("Orc/East.png"),
            CreateImageFromSource("Orc/SouthEast.png"),
            CreateImageFromSource("Orc/South.png"),
            CreateImageFromSource("Orc/SouthWest.png"),
            CreateImageFromSource("Orc/West.png"),
            CreateImageFromSource("Orc/NorthWest.png")
        };

        //Troll base constants
        public static readonly Image[] TrollImages = new Image[9]
        {
            CreateImageFromSource("Troll/None.png"),
            CreateImageFromSource("Troll/North.png"),
            CreateImageFromSource("Troll/NorthEast.png"),
            CreateImageFromSource("Troll/East.png"),
            CreateImageFromSource("Troll/SouthEast.png"),
            CreateImageFromSource("Troll/South.png"),
            CreateImageFromSource("Troll/SouthWest.png"),
            CreateImageFromSource("Troll/West.png"),
            CreateImageFromSource("Troll/NorthWest.png")
        };
        //NPCs
        //Vendor
        public static readonly Image[] Vendor = new Image[1]
        {
            CreateImageFromSource("NPCs/Vendor.png")
        };

        //Trainer
        public static readonly Image[] Trainer = new Image[1]
        {
            CreateImageFromSource("NPCs/Trainer.png")
        };

        //Items
        //Boots
        public static readonly Image Boots = CreateImageFromSource("Items/Boots.png");

        //Helmet
        public static readonly Image Helmet = CreateImageFromSource("Items/Helmet.png");
        //Pants
        public static readonly Image Pants = CreateImageFromSource("Items/Pants.png");
        //Vest
        public static readonly Image Vest = CreateImageFromSource("Items/Vest.png");
        //Hand items
        //Axe
        public static readonly Image Axe = CreateImageFromSource("Items/Axe.png");
        //Shield
        public static readonly Image Shield = CreateImageFromSource("Items/Shield.png");
        //Sword
        public static readonly Image Sword = CreateImageFromSource("Items/Sword.png");
        //Timeoutable Items
        //DamagePotion
        public static readonly Image DamagePotion = CreateImageFromSource("Items/DamagePotion.png");
        //HealthPotion
        public static readonly Image HealthPotion = CreateImageFromSource("Items/HealthPotion.png");

        private static Image CreateImageFromSource(string path)
        {
            Uri uri = new Uri(_baseUri + path);
            BitmapImage bitmapImage = new BitmapImage(uri);
            Image image = new Image();
            image.Source = bitmapImage;
            return image;
        }
    }
}
