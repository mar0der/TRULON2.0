namespace Trulon.Models.Items
{
    public abstract class Potion : Item
    {
        public int SpeedPointsBuff { get; set; }

        public int DefensePointsBuff { get; set; }

        public int AttackPointsBuff { get; set; }

        public int HealthPointsBuff { get; set; }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
