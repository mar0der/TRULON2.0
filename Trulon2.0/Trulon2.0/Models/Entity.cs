using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Trulon.Models
{
    public abstract class Entity : GameObject
    {
        protected Entity(
            string name,
            Texture2D image,
            Rectangle bounds,
            Vector2 position,
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level,
            List<Item> inventory,
            bool isAlive)
            : base(name, image, bounds, position)
        {
            this.AttackPoints = attackPoints;
            this.DefensePoints = defencePoints;
            this.SpeedPoints = speedPoints;
            this.HealthPoints = healthPoints;
            this.Level = level;
            this.Inventory = inventory;
            this.IsAlive = isAlive;
        }

        public virtual int AttackPoints { get; set; }
        public virtual int DefensePoints { get; set; }
        public virtual int SpeedPoints { get; set; }
        public virtual int HealthPoints { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; }
        public bool IsAlive { get; set; }

        protected abstract void Interact();

        protected abstract void Move();

        protected abstract void Die();


    }
}
