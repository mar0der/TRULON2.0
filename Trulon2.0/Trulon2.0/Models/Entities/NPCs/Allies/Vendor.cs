namespace Trulon.Models.Entities.NPCs.Allies
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using global::Trulon.Models.Items.Equipments;
    using global::Trulon.Models.Items.Potions;
    using Config;

    public class Vendor : Ally
    {
        #region Constants
        private const string DefaultName = "Vendor";
        private const int DefaultAttackPoints = 0;
        private const int DefaultDefensePoints = 0;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 60;
        private const int DefaultLevel = 10;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 64;
        #endregion

        public Vendor(int x, int y)
        {
            this.Name = DefaultName;
            this.BaseAttack = DefaultAttackPoints;
            this.BaseDefense = DefaultDefensePoints;
            this.BaseSpeed = DefaultSpeedPoints;
            this.BaseHealth = DefaultHealthPoints;
            this.Level = DefaultLevel;
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + Width, y + Height, 0));
            this.Inventory = new Item[Config.TotalItemsCount] {
                new Sword(), 
                new Helmet(),
                new Vest(),
                new Boots(),
                new DamagePotion(),
                new DefensePotion(),
                new HealthPotion(),
                new SpeedPotion()
            };
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
