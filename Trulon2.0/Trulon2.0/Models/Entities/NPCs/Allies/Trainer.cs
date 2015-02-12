//namespace GameEngine.Models.Entities.NPCs.Allies
//{
//    using System.Collections.Generic;

//    using global::GameEngine.Models.Items.Equipments;
//    using global::GameEngine.Models.Items.Potions;

//    public class Trainer : Ally
//    {
//        private const string Name = "Trainer";
//        private const int AttackPoints = 5;
//        private const int DefencePoints = 5;
//        private const int SpeedPoints = 5;
//        private const int HealthPoints = 60;
//        private const int Level = 10;

//        public static readonly List<Item> TrainerInventory = new List<Item>()
//        {
//            new Helmet(),
//            new Vest(),
//            new Boots(),
//            new DamagePotion(),
//            new DefencePotion(),
//            new HealthPotion(),
//            new SpeedPotion()
//        };

//        public Trainer()
//            : base(
//            Name, 
//            AttackPoints,
//            DefencePoints,
//            SpeedPoints,
//            HealthPoints,
//            Level, 
//            new List<Item>())
//        {

//        }

//        protected override void Die()
//        {
//            //immortality
//        }
//    }
//}
