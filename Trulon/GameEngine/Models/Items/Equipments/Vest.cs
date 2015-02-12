using GameEngine.Enums;

namespace GameEngine.Models.Items.Equipments
{
    public class Vest : Equipment
    {
        private const string Name = "Vest";
        private const EquipmentSlots Slot = EquipmentSlots.Body;

        public Vest(int defensePointsBuff = 10) 
            : base(Name, Slot)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
