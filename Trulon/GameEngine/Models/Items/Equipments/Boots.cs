namespace GameEngine.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        public Boots(string name) 
            : base(name)
        {
            //this.SpeedPointsBuff = Config.Config.Spee;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
