using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Entities.NPCs
{
    public abstract class Enemy : NonPlayerCharacter
    {
        public int ExperienceReward { get; set; }
        public int CoinsReward { get; set; }

    }
}
