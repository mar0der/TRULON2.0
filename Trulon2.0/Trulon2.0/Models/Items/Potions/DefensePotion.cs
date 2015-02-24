namespace Trulon.Models.Items.Potions
{
    public class DefensePotion : Potion
    {
        private const string DefaultName = "DefensePotion";
        private const int DefaultTimeout = 600;
        private const int DefaultCountdown = 600;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefencePointsBuff = 10;
        private const int DefaultHealthPointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultAttackRangeBuff = 0;
        private const int DefaultPrice = 20;

        public DefensePotion()
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
