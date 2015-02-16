using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.Players
{
    public class Paladin : Player
    {
        #region Constants
        private readonly EntityEquipment _defaultEquipment = new EntityEquipment();
        private const string DefaultName = "Paladin";
        private const int DefaultAttackPoints = 7;
        private const int DefaultDefencePoints = 3;
        private const int DefaultSpeedPoints = 5;
        private const int DefaultHealthPoints = 90;
        private const int DefaultLevel = 1;
        private const int DefaultExperience = 0;
        private const int DefaultCoins = 10;
        private const int DefaultSkillPoints = 0;
        private const int DefaultAttackSkill = 0;
        private const int DefaultDefenseSkill = 0;
        private const int DefaultSpeedSkill = 0;
        private const int DefaultHealthSkill = 0;
        private const int DefaultWidth = 64;
        private const int DefaultHeight = 64;
        #endregion

        public Paladin(int x, int y)
        {
            this.Position = new Vector2(x, y);
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
            this.Bounds = new Rectangle(x, y, DefaultWidth, DefaultHeight);
            this.PlayerEquipment = _defaultEquipment;
            this.IsAlive = true;
        }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            this.Image = texture;
            //Starting position of the player
            this.Position = position;

            //Set the player to be active

            //Set player health
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, null, Color.White, 0F, Vector2.Zero, 1F, SpriteEffects.None, 0F);
        }
    }
}
