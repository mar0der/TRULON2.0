namespace Trulon.Models.Entities.NPCs.Allies
{
    using System;
    using Microsoft.Xna.Framework;
    using global::Trulon.Config;

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
            this.Position = new Vector2(x, y);
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + this.Width, y + this.Height, 0));
            this.Inventory = new Item[Config.TotalItemsCount];
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }
    }
}
