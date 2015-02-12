namespace GameEngine.Models.Entities
{
    using System.Collections.Generic;

    public abstract class NonPlayerCharacter : Entity
    {
        protected NonPlayerCharacter(
            string name, 
            int attackPoints, 
            int defencePoints, 
            int speedPoints, 
            int healthPoints, 
            int level, 
            List<Item> inventory)
            : base(name, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {

        }
    }
}
