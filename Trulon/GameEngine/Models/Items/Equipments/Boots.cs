namespace GameEngine.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        public Boots(Equipment equipment, int speedPointsBuff) : base(equipment)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
