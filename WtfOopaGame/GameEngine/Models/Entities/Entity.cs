using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Interfaces;

namespace GameEngine.Models.Entities
{
    public abstract class Entity : GameObject, IMovable, ICollidable

    {
        public abstract void Update(Enums.Direction direction);
    }
}
