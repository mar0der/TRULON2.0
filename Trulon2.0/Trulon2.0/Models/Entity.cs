namespace Trulon.Models
{
    using System.Collections.Generic;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using Config;

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
        public virtual int Level { get; set; }
        public Item[] Inventory { get; set; }
        public bool IsAlive { get; set; }

        public string PreviousDirection { get { return this.previousDirection; } }

        protected abstract void Move();



        public override void Update()
        {
            this.Move();
            //This is needed because the bounding box is a separate object from the image and we have to move it with it.
            this.Bounds = new BoundingBox(new Vector3(this.Position.X, this.Position.Y, 0), new Vector3(this.Position.X + this.Width, Position.Y +this.Height, 0));

            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                this.UpdateAttackBoundsRight();
                this.previousDirection = "right";
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                this.UpdateAttackBoundsLeft();
                this.previousDirection = "left";
            }
            else
            {
                if (previousDirection == "right")
                {
                    this.UpdateAttackBoundsRight();
                }
                else
                {
                    this.UpdateAttackBoundsLeft();
                }
            }
        }

        private void UpdateAttackBoundsLeft()
        {
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X, this.Position.Y, 0f),
                new Vector3(this.Position.X + this.Width + this.AttackRadius, this.Position.Y + this.Height, 0f));
        }

        private void UpdateAttackBoundsRight()
        {
            this.AttackBounds = new BoundingBox(
                new Vector3(this.Position.X, this.Position.Y, 0f),
                new Vector3(this.Position.X + this.Width + this.AttackRadius, this.Position.Y + this.Height, 0f));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(this.Image, this.Position, Color.White);
        }

    }
}
