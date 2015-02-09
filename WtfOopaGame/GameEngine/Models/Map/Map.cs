using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Interfaces;
using GameEngine.Models.Entities.EntityTypes.FightingTypes;
using System.Windows.Controls;
using GameEngine.Models.Entities.EntityTypes.FightingTypes.PlayerTypes;
using GameEngine.CoreLogic;

namespace GameEngine.Models.Map
{
    public class Map : GameObject, IMovable
    {
        /// <summary>
        /// Initializes an instance of the Map object.
        /// </summary>
        public Map()
        {
            this.Areas = Generator.GetMapAreas();
            this.Player = PlayerManager.GetPlayer();
        }

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
            this.Player.Update(direction);

            foreach (var area in Areas)
            {
                area.Update(direction);
            }
        }
    }
}
