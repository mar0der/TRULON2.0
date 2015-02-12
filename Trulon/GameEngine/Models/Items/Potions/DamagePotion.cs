namespace GameEngine.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        public DamagePotion(string name, int timeout, int countdown, bool hasTimedOut, int attackPointsBuff)
            : base(name, timeout, countdown, hasTimedOut)
        {
            //this.AttackPointsBuff = Config;
        }

        public int AttackPointsBuff { get; set; }
    }
}
