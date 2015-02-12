using GameEngine.Enums;

namespace GameEngine.Models.Items.Equipments
{
    public class Vest : Equipment
    {
        public Vest(
            string name = "Vest",
            EquipmentSlots slot = EquipmentSlots.Body,
            int defensePointsBuff = 10)
            : base(name, slot)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
