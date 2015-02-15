namespace Trulon.Models.Entities.Players
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public class Paladin : Player
    {
        public Paladin()
            : this(new EntityEquipment())
        {
        }
        public Paladin(
            EntityEquipment playerEquipment,
            string name = "Paladin",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            int attackPoints = 7,
            int defencePoints = 3,
            int speedPoints = 6,
            int healthPoints = 90,
            int level = 1,
            List<Item> inventory = null,
            bool isAlive = true,
            int experience = 0,
            int coins = 10,
            int skillPoints = 0,
            int attackSkill = 0,
            int defenseSkill = 0,
            int speedSkill = 0,
            int healthSkill = 0)
            : base(
            playerEquipment,
            name,
            image,
            bounds,
            position,
            attackPoints,
            defencePoints,
            speedPoints,
            healthPoints,
            level,
            inventory,
            isAlive,
            experience,
            coins,
            skillPoints,
            attackSkill,
            defenseSkill,
            speedSkill,
            healthSkill)
        {
        }

        protected override IList<Entity> GetEntitiesInRange(IList<Entity> entities)
        {
            throw new System.NotImplementedException();
        }

        protected override void Interact()
        {
            throw new System.NotImplementedException();
        }

        protected override void Move()
        {
            throw new System.NotImplementedException();
        }

        protected override void Die()
        {
            throw new System.NotImplementedException();
        }

        protected override void AddExperience()
        {
            throw new System.NotImplementedException();
        }

        protected override void AddCoins()
        {
            throw new System.NotImplementedException();
        }

        protected override void Buy()
        {
            throw new System.NotImplementedException();
        }

        protected override void AddSkillPoints()
        {
            throw new System.NotImplementedException();
        }

        protected override void UseEquipment()
        {
            throw new System.NotImplementedException();
        }

        protected override void DrinkPotion()
        {
            throw new System.NotImplementedException();
        }

        protected void Attack()
        {
            throw new System.NotImplementedException();
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
