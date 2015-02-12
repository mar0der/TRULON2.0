namespace GameEngine.Models.Entities.NPCs.Enemies
{
    using System.Collections.Generic;

    public class Goblin : Enemy
    {
        public Goblin(
            string name = "Goblin",
            int attackPoints = 15,
            int defencePoints = 15,
            int speedPoints = 7,
            int healthPoints = 90,
            int level = 3,
            List<Item> inventory = null,
            int experienceReward = 70,
            int coinsReward = 50)
            : base(
            name, 
            attackPoints,
            defencePoints, 
            speedPoints, 
            healthPoints, 
            level, 
            inventory, 
            experienceReward, 
            coinsReward)
        {

        }

        protected override void Interact()
        {
            //Attack();
        }

        protected override void Move()
        {
            //arteficial intelligence
        }

        protected override void Die()
        {
            //die and drop item.
        }
    }
}
