using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Interfaces;
using GameEngine.Models.Entities.EntityTypes.FightingTypes;
using System.Windows.Controls;

namespace GameEngine.Models.Map
{
    public class Map : GameObject, IMovable
    {
        List<Area> Areas { get; set; }

        Player Player { get; set; }

        /// <summary>
        /// Returns all images contained in the current map (Entity images included)
        /// </summary>
        public List<Image> Images
        {
            get
            {
                //To Do
                return new List<Image>();
            }
        }

        public void Update(Enums.Direction direction)
        {
            throw new NotImplementedException();
        }
    }
}
