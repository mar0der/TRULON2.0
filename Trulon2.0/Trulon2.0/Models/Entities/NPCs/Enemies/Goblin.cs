namespace Trulon.Models.Entities.NPCs.Enemies
{
    using Microsoft.Xna.Framework;
    using global::Trulon.Enums;

    public class Goblin : Enemy
    {
        #region Constants
        private const Names DefaultName = Names.Goblin;
        private const int DefaultAttackPoints = 2;
        private const int DefaultDefensePoints = 5;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 20;
        private const int DefaultAttackRadius = 40;
        private const int DefaultLevel = 1;
        private const int DefaultExperienceReward = 75;
        private const int DefaultCoinsReward = 30;
        private const int DefaultWidth = 32;
        private const int DefaultHeight = 96;
        #endregion

        public Goblin(int x, int y)
        {
            this.Name = DefaultName;
            this.BaseAttack = DefaultAttackPoints;
            this.BaseDefense = DefaultDefensePoints;
            this.BaseSpeed = DefaultSpeedPoints;
            this.BaseHealth = DefaultHealthPoints;
            this.Level = DefaultLevel;
            this.ExperienceReward = DefaultExperienceReward;
            this.CoinsReward = DefaultCoinsReward;
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.Position = new Vector2(x, y);
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + Width, y + Height, 0));
            //this.AttackBounds = new BoundingSphere(new Vector3(x + Width / 2, y + Height * 0.25f, 0f), DefaultAttackRadius);
            this.BaseAttackRadius = DefaultAttackRadius;
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X + 2 * this.Width, this.Position.Y, 0f),
                new Vector3(this.Position.X + 2 * this.Width + this.BaseAttackRadius, this.Position.Y + this.BaseAttackRadius, 0f));
            this.IsAlive = true;
        }
    }
}
