namespace Trulon.Models.Entities.NPCs.Enemies
{
    using Microsoft.Xna.Framework;
    using global::Trulon.Enums;

    public class Robo : Enemy
    {
        #region Constants
        private const Names DefaultName = Names.Robo;
        private const int DefaultAttackPoints = 7;
        private const int DefaultDefensePoints = 7;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 40;
        private const int DefaultAttackRadius = 40;
        private const int DefaultLevel = 2;
        private const int DefaultExperienceReward = 80;
        private const int DefaultCoinsReward = 40;
        private const int DefaultWidth = 128;
        private const int DefaultHeight = 128;
        #endregion

        public Robo(int x, int y)
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
            this.BaseAttackRadius = DefaultAttackRadius;
            this.IsAlive = true;
        }
    }
}
