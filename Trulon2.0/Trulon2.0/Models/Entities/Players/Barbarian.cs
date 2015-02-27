namespace Trulon.Models.Entities.Players
{
    using Microsoft.Xna.Framework;
    using global::Trulon.Config;
    using global::Trulon.Enums;

    public class Barbarian : Player
    {
        #region Constants
        private const Names DefaultName = Names.Barbarian;
        private const int DefaultAttackPoints = 7;
        private const int DefaultDefencePoints = 3;
        private const int DefaultSpeedPoints = 4;
        private const int DefaultHealthPoints = 100;
        private const int DefaultAttackRadius = 60;
        private const int DefaultLevel = 1;
        private const int DefaultExperience = 0;
        private const int DefaultCoins = 20;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 96;
        #endregion
        public Barbarian(int x, int y)
        {
            this.Name = DefaultName;
            this.BaseAttack = DefaultAttackPoints;
            this.BaseDefense = DefaultDefencePoints;
            this.BaseSpeed = DefaultSpeedPoints;
            this.HealthPoints = DefaultHealthPoints;
            this.Level = DefaultLevel;
            this.Experience = DefaultExperience;
            this.Coins = DefaultCoins;
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.Position = new Vector2(x, y);
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + Width, y + Height, 0));
            this.BaseAttackRadius = DefaultAttackRadius;
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X + 2 * this.Width, this.Position.Y + 64, 0F),
                new Vector3(this.Position.X + 2 * this.Width + this.BaseAttackRadius, this.Position.Y + this.BaseAttackRadius + 64, 0F));
            this.PlayerEquipment = new EntityEquipment();
            this.Inventory = new Item[Config.InventorySize];
            this.IsAlive = true;
            this.CurrentMaxHealth = DefaultHealthPoints;
        }
    }
}
