using Trulon.Interfaces;

namespace Trulon.Models.Items.Equipments
{
    using global::Trulon.Enums;

    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    public class Helmet : Equipment, IEquipable
    {
        public Helmet(
            string name = "Helmet",
            Texture2D image = null,
            Rectangle bounds = new Rectangle(),
            Vector2 position = new Vector2(),
            EquipmentSlots slot = EquipmentSlots.Head,
            int attackPointsBuff = 0,
            int defensePointsBuff = 0,
            int speedPointsBuff = 10)
            : base(name, image, bounds, position, slot)
        {
            this.AttackPointsBuff = attackPointsBuff;
            this.DefensePointsBuff = defensePointsBuff;
            this.SpeedPointsBuff = speedPointsBuff;
        }

        public int AttackPointsBuff { get; set; }
        public int DefensePointsBuff { get; set; }
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
