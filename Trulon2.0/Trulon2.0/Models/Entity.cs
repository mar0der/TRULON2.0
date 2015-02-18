namespace Trulon.Models
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Entity : GameObject
    {
        public int BaseAttack { get; protected set; }
        public int BaseDefense { get; protected set; }
        public int BaseSpeed { get; protected set; }
        public int BaseHealth { get; protected set; }
        public int BaseAttackRadius { get; protected set; }
        public BoundingSphere AttackBounds { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; }
        public bool IsAlive { get; set; }

        protected abstract void Move();

        public override void Initialize(Texture2D texture, Vector2 position)
        {
            this.Image = texture;
            this.Position = position;
        }
        public override void Update()
        {
            this.Move(); 
            //This is needed because the bounding box is a separate object from the image and we have to move it with it.
            this.Bounds = new BoundingBox(new Vector3(Position.X, Position.Y, 0), new Vector3(Position.X + Width, Position.Y + Height, 0));
            this.AttackBounds = new BoundingSphere(new Vector3(Position.X + Width / 2, Position.Y + Height * 0.25f, 0f), this.BaseAttackRadius);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, Color.White);
        }

    }
}
