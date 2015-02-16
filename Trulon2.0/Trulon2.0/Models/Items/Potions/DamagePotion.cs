using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models.Items.Potions
{
    public class DamagePotion : Potion
    {
        //public DamagePotion(
        //    string name = "Damage Potion",
        //    Texture2D image = null,
        //    Rectangle bounds = new Rectangle(),
        //    Vector2 position = new Vector2(),
        //    int timeout = 5,
        //    int countdown = 5,
        //    bool hasTimedOut = false,
        //    int attackPointsBuff = 10)
        //    : base(name, image, bounds, position, timeout, countdown, hasTimedOut)
        //{
        //    this.AttackPointsBuff = attackPointsBuff;
        //}

        public int AttackPointsBuff { get; set; }

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            throw new NotImplementedException();
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}
