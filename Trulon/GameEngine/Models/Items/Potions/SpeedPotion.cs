namespace GameEngine.Models.Items.Potions
{
    public class SpeedPotion : Potion
    {
        public SpeedPotion(string name, int timeout, int countdown, bool hasTimedOut, int speedPointsBuff)
            : base(name, timeout, countdown, hasTimedOut)
        {
            //this.SpeedPointsBuff = Config;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
