namespace GameEngine.Models.Items.Potions
{
    public class SpeedPotion : Potion
    {
        public SpeedPotion(int timeout, int countdown, bool hasTimedOut, int speedPointsBuff)
            : base(timeout, countdown, hasTimedOut)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
