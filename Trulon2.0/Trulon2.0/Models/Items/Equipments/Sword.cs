namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    public class Sword : Equipment
    {
        private const Names DefaultName = Names.Sword;
        private const EquipmentSlots DefaultSlot = EquipmentSlots.RightHand;
        private const int DefaultAttackPointsBuff = 30;
        private const int DefaultDefensePointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultPrice = 60;

        public Sword()
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
