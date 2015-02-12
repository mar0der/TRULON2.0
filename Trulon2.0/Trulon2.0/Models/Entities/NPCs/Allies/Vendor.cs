namespace GameEngine.Models.Entities.NPCs.Allies
{
    using System.Collections.Generic;

    using global::GameEngine.Models.Items;
    using global::GameEngine.Models.Items.Equipments;
    using global::GameEngine.Models.Items.Potions;

    public class Vendor : Ally
    {
        public static List<Item> VendorInventory;

        public Vendor(string name = "Vendor",
            int attackPoints = 5,
            int defencePoints = 5,
            int speedPoints = 5,
            int healthPoints = 60,
            int level = 10,
            List<Item> inventory = null)
            : base(name, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {
            VendorInventory = new List<Item>()
            {
                new Helmet(),
                new Vest(),
                new Boots(),
                new DamagePotion(),
                new DefencePotion(),
                new HealthPotion(),
                new SpeedPotion()
            };
            this.Inventory = VendorInventory;
        }

        protected override void Die()
        {
            //immortality
        }
    }
}
