namespace Trulon.Models.Items.Potions
{
    using global::Trulon.Enums;

    public class SpeedPotion : Potion
    {
        private const Names DefaultName = Names.SpeedPotion;
        private const int DefaultCountdown = 600;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefencePointsBuff = 0;
        private const int DefaultHealthPointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 4;
        private const int DefaultPrice = 20;

        public SpeedPotion()
        {
            this.Name = DefaultName;
            this.Countdown = DefaultCountdown;
            this.HasTimedOut = DefaultHasTimedOut;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefencePointsBuff;
            this.HealthPointsBuff = DefaultHealthPointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.Price = DefaultPrice;
        }

        public override void ResetCountdown()
        {
            this.Countdown = DefaultCountdown;
        }
    }
}
