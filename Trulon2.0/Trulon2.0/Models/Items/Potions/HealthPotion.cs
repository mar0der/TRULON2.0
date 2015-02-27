namespace Trulon.Models.Items.Potions
{
    using global::Trulon.Enums;

    public class HealthPotion : Potion
    {
        private const Names DefaultName = Names.HealthPotion;
        private const bool DefaultHasTimedOut = false;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefencePointsBuff = 0;
        private const int DefaultHealthPointsBuff = 30;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultPrice = 20;

        public HealthPotion()
        {
            this.Name = DefaultName;
            this.HasTimedOut = DefaultHasTimedOut;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefencePointsBuff;
            this.HealthPointsBuff = DefaultHealthPointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.Price = DefaultPrice;
        }
    }
}
