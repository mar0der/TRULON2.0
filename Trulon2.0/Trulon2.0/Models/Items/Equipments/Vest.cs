using GameEngine.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Equipments
{
    public class Vest : Equipment
    {
        public Vest(
            string name = "Vest",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            EquipmentSlots slot = EquipmentSlots.Body,
            int defensePointsBuff = 10)
            : base(name, image, bounds, slot)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }
    }
}
