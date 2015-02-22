namespace Trulon.Models
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public abstract class Entity : GameObject
    {
        private string previousDirection = "right";

        public int BaseAttack { get; protected set; }
        public int BaseDefense { get; protected set; }
        public int BaseSpeed { get; protected set; }
        public int BaseHealth { get; protected set; }
        public int BaseAttackRadius { get; protected set; }
        public virtual int AttackRadius { get; set; }
        public BoundingBox AttackBounds { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; }
        public bool IsAlive { get; set; }

        public string PreviousDirection { get { return this.previousDirection; } }

        protected abstract void Move();



        public override void Update()
        {
            this.Move();
            //This is needed because the bounding box is a separate object from the image and we have to move it with it.
            this.Bounds = new BoundingBox(new Vector3(Position.X, Position.Y, 0), new Vector3(Position.X + Width, Position.Y + Height, 0));

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                this.UpdateBoundingBoxRight();
                this.previousDirection = "right";
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.UpdateBoundingBoxLeft();
                this.previousDirection = "left";
            }
            else
            {
                if (previousDirection == "right")
                {
                    this.UpdateBoundingBoxRight();
                }
                else
                {
                    this.UpdateBoundingBoxLeft();
                }
            }
        }

        private void UpdateBoundingBoxLeft()
        {
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X, this.Position.Y, 0f),
                new Vector3(this.Position.X + this.Width + this.AttackRadius, this.Position.Y + this.Height, 0f));
        }

        private void UpdateBoundingBoxRight()
        {
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X, this.Position.Y, 0f),
                new Vector3(this.Position.X + this.Width + this.AttackRadius, this.Position.Y + this.Height, 0f));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, Color.White);
        }

    }
}
