using System;
using GameEngine.Interfaces;

namespace GameEngine.Models.Items.ItemTypes
{
    public abstract class Potion : Item, ITimeoutable
    {
        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }

        public override void Use()
        {
            throw new NotImplementedException();
        }
    }
}
