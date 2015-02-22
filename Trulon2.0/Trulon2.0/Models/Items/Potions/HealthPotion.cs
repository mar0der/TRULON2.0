using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Potions
{
    public class HealthPotion : Potion
    {
        private const string DefaultName = "HealthPotion";
        private const int DefaultTimeout = 55;
        private const int DefaultCountdown = 55;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefencePointsBuff = 0;
        private const int DefaultHealthPointsBuff = 10;
        private const int DefaultSpeedPointsBuff = 0;
        public HealthPotion()
        {
            this.Name = DefaultName;
            this.Timeout = DefaultTimeout;
            this.Countdown = DefaultCountdown;
            this.HasTimedOut = DefaultHasTimedOut;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefencePointsBuff;
            this.HealthPointsBuff = DefaultHealthPointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
        }
    }
}
