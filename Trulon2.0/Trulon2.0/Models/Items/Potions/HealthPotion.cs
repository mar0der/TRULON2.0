namespace GameEngine.Models.Items.Potions
{
    public class HealthPotion : Potion
    {
        public HealthPotion(
            string name = "Health Potion",
            int timeout = 5,
            int countdown = 5,
            bool hasTimedOut = false,
            int healthPointsBuff = 10)
            : base(name, timeout, countdown, hasTimedOut)
        {
            this.HealthPointsBuff = healthPointsBuff;
        }

        public int HealthPointsBuff { get; set; }
    }
}
