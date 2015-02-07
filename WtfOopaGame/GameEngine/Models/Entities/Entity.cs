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
        //To DO - Sprite Collection

        public void Update(Enums.Direction direction)
        {
            //Update position

            //Update Object image with the correct sprite image
            throw new NotImplementedException();
        }
    }
}
