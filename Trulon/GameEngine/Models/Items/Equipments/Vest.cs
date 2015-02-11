namespace GameEngine.Models.Items.Equipments
{
    public class Vest : Equipment
    {
        public Vest(Equipment equipment, int defensePointsBuff) : base(equipment)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }

    }
}
