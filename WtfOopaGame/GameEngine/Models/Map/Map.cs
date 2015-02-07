using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Interfaces;
using GameEngine.Models.Entities.EntityTypes.FightingTypes;

namespace GameEngine.Models.Map
{
    public class Map : GameObject, IMovable
    {
        List<Area> Areas { get; set; }

        Player Player { get; set; }

        public void Update(Enums.Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
