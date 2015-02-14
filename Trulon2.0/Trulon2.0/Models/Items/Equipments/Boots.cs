using GameEngine.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Equipments
{
    public class Boots : Equipment
    {
        public Boots(
            string name = "Boots",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            EquipmentSlots slot = EquipmentSlots.Feet,
            int speedPointsBuff = 10)
            : base(name, image, bounds, position, slot)
        {
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int SpeedPointsBuff { get; set; }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new System.NotImplementedException();
        }

        public override void Update()
        {
            throw new System.NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new System.NotImplementedException();
        }
    }
}
