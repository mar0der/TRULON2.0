namespace GameEngine.Models.Items.Potions
{
    public class SpeedPotion : Potion
    {
        private const string Name = "Speed Potion";
        private const int Timeout = 5;
        private const int Countdown = 5;
        private const bool HasTimedOut = false;

        public SpeedPotion(int speedPointsBuff = 10)
            : base(Name, Timeout, Countdown, HasTimedOut)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
