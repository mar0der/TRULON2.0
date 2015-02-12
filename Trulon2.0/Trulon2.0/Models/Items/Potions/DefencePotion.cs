namespace GameEngine.Models.Items.Potions
{
    public class DefencePotion : Potion
    {
        public DefencePotion(
            string name = "Defense Potion",
            int timeout = 5,
            int countdown = 5,
            bool hasTimedOut = false,
            int defensePointsBuff = 10)
            : base(name, timeout, countdown, hasTimedOut)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
