namespace Trulon.Models.Items
{
    using global::Trulon.Interfaces;

    public abstract class Potion : Item, IItem, IUsable
    {
        public int SpeedPointsBuff { get; set; }

        public int DefensePointsBuff { get; set; }

        public int AttackPointsBuff { get; set; }

        public int HealthPointsBuff { get; set; }

        public int AttackRadiusBuff { get; set; }

        public int Price { get; set; }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
