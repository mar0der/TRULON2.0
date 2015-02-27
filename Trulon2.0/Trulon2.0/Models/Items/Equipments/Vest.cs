namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    public class Vest : Equipment
    {
        private const Names DefaultName = Names.Vest;
        private const EquipmentSlots DefaultSlot = EquipmentSlots.Body;
        private const int DefaultAttackPointsBuff = 0;
        private const int DefaultDefensePointsBuff = 40;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultPrice = 80;

        public Vest()
        {
            this.Name = DefaultName;
            this.Slot = DefaultSlot;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.Price = DefaultPrice;
        }
    }
}
