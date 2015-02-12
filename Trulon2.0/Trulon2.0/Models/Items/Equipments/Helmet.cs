using GameEngine.Enums;

namespace GameEngine.Models.Items.Equipments
{
    public class Helmet : Equipment
    {
        public Helmet(
            string name = "Helmet", 
            EquipmentSlots slot = EquipmentSlots.Head, 
            int defensePointsBuff = 10)
            : base(name, slot)
        {
            this.DefensePointsBuff = defensePointsBuff ;
        }

        public int DefensePointsBuff { get; set; }
    }
}
