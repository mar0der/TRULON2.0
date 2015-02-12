using GameEngine.Enums;

namespace GameEngine.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        private const string Name = "Boots";
        private const EquipmentSlots Slot = EquipmentSlots.Feet;

        public Boots(int speedPointsBuff = 10)
            : base(Name, Slot)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
