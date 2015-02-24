namespace Trulon.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        private const string DefaultName = "DamagePotion";
        private const int DefaultTimeout = 600;
        private const int DefaultCountdown = 600;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultAttackPointsBuff = 10;
        private const int DefaultDefencePointsBuff = 0;
        private const int DefaultHealthPointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultAttackRangeBuff = 0;
        private const int DefaultPrice = 20;

        public DamagePotion()
        {
            this.Name = DefaultName;
            this.Timeout = DefaultTimeout;
            this.Countdown = DefaultCountdown;
            this.HasTimedOut = DefaultHasTimedOut;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefencePointsBuff;
            this.HealthPointsBuff = DefaultHealthPointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.AttackRadiusBuff = DefaultAttackRangeBuff;
            this.Price = DefaultPrice;
        }
    }
}
