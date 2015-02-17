

namespace Trulon.Models.Entities.NPCs
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Enemy : NonPlayerCharacter
    {
        public int ExperienceReward { get; set; }
        public int CoinsReward { get; set; }
        public override void Update()
        {
            if (this.BaseHealth <= 0)
            {
                this.IsAlive = false;
            }
        }
    }
}
