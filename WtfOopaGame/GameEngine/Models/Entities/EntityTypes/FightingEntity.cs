using System;
using System.Linq.Expressions;

namespace GameEngine.Models.Entities.EntityTypes
{
    public abstract class FightingEntity : Entity, IColidable
    {
        public int Range { get; set; }

        public int AttackPoints { get; set; }

        public int DefensePoints { get; set; }

        public int HealthPoints { get; set; }

        public int AttackSpeed { get; set; }

        public int Level { get; set; }

        public bool IsAlive { get; set; }

        public void Attack(FightingEntity defender)
        {
            throw new NotImplementedException();
        }

        public abstract void Die();
    }
}
