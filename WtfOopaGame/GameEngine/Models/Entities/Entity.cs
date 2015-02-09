using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using GameEngine.Interfaces;

namespace GameEngine.Models.Entities
{
    public abstract class Entity : GameObject, IMovable, ICollidable
    {
        public Image[] Images { get; set; }

        public abstract void Update(Enums.Direction direction);
    }
}
