namespace GameEngine.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        public DamagePotion(int timeout, int countdown, bool hasTimedOut, int attackPointsBuff)
            : base(timeout, countdown, hasTimedOut)
        {
            this.AttackPointsBuff = attackPointsBuff;
        }

        public int AttackPointsBuff { get; set; }
    }
}
