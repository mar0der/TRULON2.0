using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Interfaces;

namespace GameEngine.Models.Items
{
    public abstract class Item : GameObject, IUsable
    {
        public int Cost { get; set; }

        public int LevelRequirement { get; set; }

        public int HealthEffect { get; set; }

        public int DefenseEffect { get; set; }

        public int AttackEffect { get; set; }

        public int AttackSpeedEffect { get; set; }

        public string Description { get; set; }

        public abstract void Use();
    }
}
