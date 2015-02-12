namespace GameEngine.Models.Entities.NPCs.Allies
{
    using System.Collections.Generic;

    using global::GameEngine.Models.Items;
    using global::GameEngine.Models.Items.Equipments;
    using global::GameEngine.Models.Items.Potions;

    public class Vendor : Ally
    {
        private const string Name = "Vendor";
        private const int AttackPoints = 5;
        private const int DefencePoints = 5;
        private const int SpeedPoints = 5;
        private const int HealthPoints = 60;
        private const int Level = 10;

        public static readonly List<Item> VendorInventory = new List<Item>()
        {
            new Helmet(),
            new Vest(),
            new Boots(),
            new DamagePotion(),
            new DefencePotion(),
            new HealthPotion(),
            new SpeedPotion()
        };

        public Vendor()
            : base(
            Name, 
            AttackPoints,
            DefencePoints,
            SpeedPoints,
            HealthPoints,
            Level, 
            VendorInventory)
        {

        }

        protected override void Die()
        {
            //immortality
        }
    }
}
