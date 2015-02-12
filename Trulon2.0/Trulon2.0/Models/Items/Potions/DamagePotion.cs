namespace GameEngine.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        public DamagePotion(
            string name = "Damage Potion",
            int timeout = 5, 
            int countdown = 5,
            bool hasTimedOut = false, 
            int attackPointsBuff = 10)
            : base(name, timeout, countdown, hasTimedOut)
        {
            this.AttackPointsBuff = attackPointsBuff;
        }

        public int AttackPointsBuff { get; set; }
    }
}
