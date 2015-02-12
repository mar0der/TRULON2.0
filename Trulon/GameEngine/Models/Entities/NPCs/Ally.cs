namespace GameEngine.Models.Entities.NPCs
{
    using System.Collections.Generic;

    public abstract class Ally : NonPlayerCharacter
    {
        protected Ally(
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
