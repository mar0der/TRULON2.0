using GameEngine.Models.Items.ItemTypes.Equipables;

namespace GameEngine.Models.Entities.EntityTypes.FightingTypes
{
    public class PlayerEquipment
    {
        public Helmet Head { get; set; }
        public Pants Legs { get; set; }
        public Vest Body { get; set; }
        public Boots Feet { get; set; }
        public HandEquipment LeftHand { get; set; }
        public HandEquipment RightHand { get; set; }
    }
}
