namespace GameEngine.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        public DefencePotion(int timeout, int countdown, bool hasTimedOut, int defensePointsBuff)
            : base(timeout, countdown, hasTimedOut)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
