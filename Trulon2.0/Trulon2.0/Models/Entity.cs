namespace Trulon.Models
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;

    public abstract class Entity : GameObject
    {
        protected string previousDirection = "right";

        public int BaseAttack { get; protected set; }
        public int BaseDefense { get; protected set; }
        public int BaseSpeed { get; protected set; }
        public int BaseHealth { get; protected set; }
        public int BaseAttackRadius { get; protected set; }
        public virtual int AttackRadius { get; set; }
        public BoundingBox AttackBounds { get; set; }
        public virtual int Level { get; set; }
        public Item[] Inventory { get; set; }
        public bool IsAlive { get; set; }

        public string PreviousDirection { get { return this.previousDirection; } }

        protected abstract void Move();

        public override void Update()
        {
            //This is needed because the bounding box is a separate object from the image and we have to move it with it.
            this.Bounds = new BoundingBox(new Vector3(this.Position.X, this.Position.Y, 0), new Vector3(this.Position.X + this.Width, Position.Y + this.Height, 0));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Image, this.Position, Color.White);
        }

    }
}
