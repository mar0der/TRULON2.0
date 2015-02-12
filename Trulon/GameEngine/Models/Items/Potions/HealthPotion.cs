namespace GameEngine.Models.Items.Potions
{
    public class HealthPotion : Potion
    {
        private const string Name = "Health Potion";
        private const int Timeout = 5;
        private const int Countdown = 5;
        private const bool HasTimedOut = false;

        public HealthPotion(int healthPointsBuff = 10)
            : base(Name, Timeout, Countdown, HasTimedOut)
        {
            this.HealthPointsBuff = healthPointsBuff;
        }

        public int HealthPointsBuff { get; set; }
    }
}
