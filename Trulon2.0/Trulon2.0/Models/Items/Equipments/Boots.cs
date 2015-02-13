using GameEngine.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        public Boots(
            string name = "Boots",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            EquipmentSlots slot = EquipmentSlots.Feet, 
            int speedPointsBuff = 10)
            : base(name, image, bounds, slot)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }
    }
}
