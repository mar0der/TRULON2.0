namespace Trulon.Models
{
    using System.Collections.Generic;

    public abstract class Entity : GameObject
    {
        protected Entity(
            int x, 
            int y,
            int attackPoints,
            int defencePoints,
            int speedPoints,
            int healthPoints,
            int level,
            List<Item> inventory,
            bool isAlive)
            : base(x, y)
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

        protected abstract IList<Entity> GetEntitiesInRange(IList<Entity> entities);

        protected abstract void Interact();

        protected abstract void Move();

        protected abstract void Die();


    }
}
