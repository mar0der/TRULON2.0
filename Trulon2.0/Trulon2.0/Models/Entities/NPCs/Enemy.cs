namespace Trulon.Models.Entities.NPCs
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Enemy : NonPlayerCharacter
    {
        protected Enemy(
            string name,
            Texture2D image,
            Rectangle bounds,
            Vector2 position,
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level,
            List<Item> inventory,
            bool isAlive,
            int experienceReward,
            int coinsReward)
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory, isAlive)
        {
            this.ExperienceReward = experienceReward;
            this.CoinsReward = coinsReward;
        }

        public int ExperienceReward { get; set; }
        public int CoinsReward { get; set; }

    }
}
