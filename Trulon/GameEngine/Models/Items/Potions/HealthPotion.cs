namespace GameEngine.Models.Items.Potions
{
    public class HealthPotion : Potion
    {
        public HealthPotion(string name, int timeout, int countdown, bool hasTimedOut, int healthPointsBuff)
            : base(name, timeout, countdown, hasTimedOut)
        {
            //this.HealthPointsBuff = Confgi;
        }

        public int HealthPointsBuff { get; set; }
    }
}
