namespace GameEngine.Models.Items.Potions
{
    public class HealthPotion : Potion
    {
        public HealthPotion(int timeout, int countdown, bool hasTimedOut, int healthPointsBuff)
            : base(timeout, countdown, hasTimedOut)
        {
            this.HealthPointsBuff = healthPointsBuff;
        }

        public int HealthPointsBuff { get; set; }
    }
}
