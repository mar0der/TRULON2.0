namespace GameEngine.Models.Items
{
    public abstract class Potion : Item
    {
        protected Potion(string name, int timeout, int countdown, bool hasTimedOut)
            : base(name)
        {
            this.Timeout = timeout;
            this.Countdown = countdown;
            this.HasTimedOut = hasTimedOut;
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
