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
<<<<<<< HEAD
            int level,
            List<Item> inventory)
            : base(name, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {

        }
=======
            int level, 
            List<Item> inventory)
            : base(name, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {
>>>>>>> e38fed55bf23c1f3d88d539bb114967d3135231b

        }
    }
}
