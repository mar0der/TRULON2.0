namespace Trulon.Models.Items.Potions
{
    using global::Trulon.Enums;

    public class DamagePotion : Potion
    {
        private const Names DefaultName = Names.DamagePotion;
        private const int DefaultCountdown = 600;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultAttackPointsBuff = 15;
        private const int DefaultDefencePointsBuff = 0;
        private const int DefaultHealthPointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultPrice = 20;

        public DamagePotion()
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
