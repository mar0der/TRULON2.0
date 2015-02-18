namespace Trulon.Models.Entities.NPCs.Enemies
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Boss : Enemy
    {
        private const string DefaultName = "Boss";
        private const int DefaultAttackPoints = 50;
        private const int DefaultDefensePoints = 50;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 1000;
        private const int DefaultAttakRadius = 100;
        private const int DefaultLevel = 5;
        private const int DefaultExperienceReward = 100;
        private const int DefaultCoinsReward = 100;
        private const int DefaultWidth = 128;
        private const int DefaultHeight = 128;

        public Boss(int x, int y)
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
            this.AttackBounds = new BoundingSphere(new Vector3(x + Width / 2, y + Height * 0.25f, 0f), DefaultAttakRadius);
            this.IsAlive = true;
        }
    }
}
