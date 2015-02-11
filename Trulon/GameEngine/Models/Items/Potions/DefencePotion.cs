namespace GameEngine.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        public DefencePotion(string name, int timeout, int countdown, bool hasTimedOut, int defensePointsBuff)
            : base(name, timeout, countdown, hasTimedOut)
        {
            //this.DefensePointsBuff = Config;
        }

        public int DefensePointsBuff { get; set; }
    }
}
