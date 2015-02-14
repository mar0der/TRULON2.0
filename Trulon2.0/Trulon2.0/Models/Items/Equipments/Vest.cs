using GameEngine.Enums;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Equipments
{
    public class Vest : Equipment
    {
        public Vest(
            string name = "Vest",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            EquipmentSlots slot = EquipmentSlots.Body,
            int defensePointsBuff = 10)
            : base(name, image, bounds, position, slot)
        {
            this.DefensePointsBuff = defensePointsBuff;
        }

        public int DefensePointsBuff { get; set; }

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
