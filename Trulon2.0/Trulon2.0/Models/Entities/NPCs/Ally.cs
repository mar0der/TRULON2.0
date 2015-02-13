using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Entities.NPCs
{
    using System.Collections.Generic;

    public abstract class Ally : NonPlayerCharacter
    {
        protected Ally(
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

        protected override void Move()
        {
            //stop moving
        }

        protected override void Interact()
        {
            //sell items or skills
        }
    }
}
