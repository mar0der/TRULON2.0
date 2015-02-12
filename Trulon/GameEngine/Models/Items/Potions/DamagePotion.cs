namespace GameEngine.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        private const string Name = "Damage Potion";
        private const int Timeout = 5;
        private const int Countdown = 5;
        private const bool HasTimedOut = false;

        public DamagePotion(int attackPointsBuff = 10)
            : base(Name, Timeout, Countdown, HasTimedOut)
        {
            this.AttackPointsBuff = attackPointsBuff;
        }

        public int AttackPointsBuff { get; set; }
    }
}
