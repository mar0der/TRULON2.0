using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Shapes;
using GameEngine.Interfaces;
using GameEngine.Models.Entities;

namespace GameEngine.Models.Map
{
    public abstract class Area :GameObject, IMovable
    {
        public Rectangle Boundary { get; set; }

        public List<Point> SpawnPoints { get; set; }

        public List<Entity> Entities { get; set; }

        public void Update(Enums.Direction direction)
        {
            //To Do: Use Point to Screen or something like that to update the Rectangle
            throw new NotImplementedException();

            //foreach (var entitiy in Entities)
            //{
            //    entitiy.Update(direction);
            //}
        }
    }
}
