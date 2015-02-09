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
            this.Areas = Generator.GetMapAreas(this);
            this.Player = PlayerManager.GetPlayer();
        }

        /// <summary>
        /// Gets or sets the Areas property.
        /// </summary>
        List<Area> Areas { get; set; }

        /// <summary>
        /// Gets or sets the Player property.
        /// </summary>
        Player Player { get; set; }

        /// <summary>
        /// Returns all images contained in the current map (Entity images included)
        /// </summary>
        public List<Image> Images
        {
            get
            {
                var output = new List<Image>();

                output.Add(Player.ObjectImage);
                //To Do

                return output;

            }
        }

        /// <summary>
        /// Updates the position of all game objects
        /// </summary>
        /// <param name="direction">The direction to move them to</param>
        public void Update(Enums.Direction direction)
        {
            this.Player.Update(direction);

            foreach (var area in Areas)
            {
                area.Update(direction);
            }
        }

        /// <summary>
        /// Refreshes the position of all Game Objects in the map by given new
        /// GameGrid size.
        /// </summary>
        public void Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
