using GameEngine.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GameEngine.Models.Items.Equipments
{
    public class Helmet : Equipment
    {
        public Helmet(
            string name = "Helmet",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            EquipmentSlots slot = EquipmentSlots.Head, 
            int defensePointsBuff = 10)
            : base(name, image, bounds, slot)
        {
            this.DefensePointsBuff = defensePointsBuff ;
        }

        public int DefensePointsBuff { get; set; }
    }
}
