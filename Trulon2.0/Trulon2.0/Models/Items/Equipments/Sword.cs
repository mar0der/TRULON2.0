namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    public class Sword : Equipment
    {
        private const string DefaultName = "Sword";
        private const EquipmentSlots DefaultSlot = EquipmentSlots.RightHand;
        private const int DefaultAttackPointsBuff = 10;
        private const int DefaultDefensePointsBuff = 0;
        private const int DefaultSpeedPointsBuff = 0;
        private const int DefaultAttackRadiusBuff = 10;

        public Sword()
        {
            this.Name = DefaultName;
            this.Slot = DefaultSlot;
            this.AttackPointsBuff = DefaultAttackPointsBuff;
            this.DefensePointsBuff = DefaultDefensePointsBuff;
            this.SpeedPointsBuff = DefaultSpeedPointsBuff;
            this.AttackRadiusBuff = DefaultAttackRadiusBuff;
        }
    }
}
