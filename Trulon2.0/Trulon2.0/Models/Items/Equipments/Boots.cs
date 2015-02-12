using GameEngine.Enums;

namespace GameEngine.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        public Boots(
            string name = "Boots", 
            EquipmentSlots slot = EquipmentSlots.Feet, 
            int speedPointsBuff = 10)
            : base(name, slot)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
