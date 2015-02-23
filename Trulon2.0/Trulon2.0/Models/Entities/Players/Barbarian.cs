namespace Trulon.Models.Entities.Players
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Config;
    public class Barbarian : Player
    {
        #region Constants
        private const string DefaultName = "Barbarian";
        private const int DefaultAttackPoints = 7;
        private const int DefaultDefencePoints = 3;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 100;
        private const int DefaultAttackRadius = 80;
        private const int DefaultLevel = 1;
        private const int DefaultExperience = 0;
        private const int DefaultCoins = 10;
        private const int DefaultSkillPoints = 0;
        private const int DefaultAttackSkill = 0;
        private const int DefaultDefenseSkill = 0;
        private const int DefaultSpeedSkill = 0;
        private const int DefaultHealthSkill = 0;
        private const int DefaultWidth = 32;
        private const int DefaultHeight = 96;
        #endregion

        public Barbarian(int x, int y)
        {
            this.Name = DefaultName;
            this.BaseAttack = DefaultAttackPoints;
            this.BaseDefense = DefaultDefencePoints;
            this.BaseSpeed = DefaultSpeedPoints;
            this.BaseHealth = DefaultHealthPoints;
            this.Level = DefaultLevel;
            this.Experience = DefaultExperience;
            this.Coins = DefaultCoins;
            this.SkillPoints = DefaultSkillPoints;
            this.AttackSkill = DefaultAttackSkill;
            this.DefenseSkill = DefaultDefenseSkill;
            this.SpeedSkill = DefaultSpeedSkill;
            this.HealthSkill = DefaultHealthSkill;
            this.Width = DefaultWidth;
            this.Height = DefaultHeight;
            this.Position = new Vector2(x, y);
            this.Bounds = new BoundingBox(new Vector3(x, y, 0), new Vector3(x + Width, y + Height, 0));
            this.BaseAttackRadius = DefaultAttackRadius;
            this.PlayerEquipment = new EntityEquipment();
            this.Inventory = new Item[Config.InventorySize];
            this.IsAlive = true;
        }

        protected override void Move()
        {

        }
    }
}
