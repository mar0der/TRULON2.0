namespace GameEngine.Models.Items.Equipments
{
    public class Helmet : Equipment
    {
        public Helmet(Equipment equipment, int defensePointsBuff) : base(equipment)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
