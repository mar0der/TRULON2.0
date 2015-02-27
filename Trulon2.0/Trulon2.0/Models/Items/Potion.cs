namespace Trulon.Models.Items
{
    using global::Trulon.Interfaces;

    public abstract class Potion : Item, IUsable
    {
        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
