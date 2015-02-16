namespace Trulon.Models.Items
{
    public abstract class Potion : Item
    {
        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
