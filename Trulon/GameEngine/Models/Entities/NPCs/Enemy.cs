namespace GameEngine.Models.Entities.NPCs
{
    using System.Collections.Generic;

    public abstract class Enemy : NonPlayerCharacter
    {
        public Enemy(
            string name, 
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level, 
            List<Item> inventory, 
            int experienceReward,
            int coinsReward)
            : base(name, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {
            this.ExperienceReward = experienceReward;
            this.CoinsReward = coinsReward;
        }

        public int ExperienceReward { get; set; }
        public int CoinsReward { get; set; }
        
    }
}
