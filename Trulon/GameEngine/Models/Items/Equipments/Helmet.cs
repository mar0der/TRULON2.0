using GameEngine.Enums;

namespace GameEngine.Models.Items.Equipments
{
    public class Helmet : Equipment
    {
        private const string Name = "Helmet";
        private const EquipmentSlots Slot = EquipmentSlots.Head;

        public Helmet(int defensePointsBuff = 10) 
            : base(Name, Slot)
        {
            this.DefensePointsBuff = defensePointsBuff ;
        }

        public int DefensePointsBuff { get; set; }
    }
}
