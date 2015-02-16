using System.Collections.Generic;

namespace Trulon.Models
{
    public abstract class Entity : GameObject
    {
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseSpeed { get; set; }
        public int BaseHealth { get; set; }
        public int Level { get; set; }
        public List<Item> Inventory { get; set; }
        public bool IsAlive { get; set; }

        protected abstract void Move();
    }
}
