﻿namespace Trulon.Models.Entities.NPCs
{
    using System.Collections.Generic;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Ally : NonPlayerCharacter
    {
        protected Ally(
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
            bool isAlive)
            : base(name, image, bounds, position, attackPoints, defencePoints, speedPoints, healthPoints, level, inventory, isAlive)
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
