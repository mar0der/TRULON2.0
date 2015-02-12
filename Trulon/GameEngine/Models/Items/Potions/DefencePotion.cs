namespace GameEngine.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        private const string Name = "Defense Potion";
        private const int Timeout = 5;
        private const int Countdown = 5;
        private const bool HasTimedOut = false;

        public DefencePotion(int defensePointsBuff = 10)
            : base(Name, Timeout, Countdown, HasTimedOut)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
