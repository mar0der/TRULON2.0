using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities
{
    using System.Collections.Generic;

    public abstract class NonPlayerCharacter : Entity
    {
        protected NonPlayerCharacter(
            string name,
            Texture2D image,
            Rectangle bounds,
            int attackPoints, 
            int defencePoints, 
            int speedPoints, 
            int healthPoints, 
            int level, 
            List<Item> inventory)
            : base(name, image, bounds, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory)
        {

        }
        
    }
}
