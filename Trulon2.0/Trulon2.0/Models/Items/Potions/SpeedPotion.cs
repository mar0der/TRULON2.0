namespace GameEngine.Models.Items.Potions
{
    public class SpeedPotion : Potion
    {
        public SpeedPotion
            (
            string name = "Speed Potion", 
            int timeout = 5, 
            int countdown = 5, 
            bool hasTimedOut = false, 
            int speedPointsBuff = 10
            ) : base(name, timeout, countdown, hasTimedOut)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
