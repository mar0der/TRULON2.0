using GameEngine.Models.Items;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Models.Items.ItemTypes;
using GameEngine.Models.Items.ItemTypes.Equipables.HandableTypes;
using GameEngine.UI;
using System.Windows.Controls;
using GameEngine.Models.Map;

namespace GameEngine.CoreLogic
{
    public class Engine
    {
        /// <summary>
        /// The parent element of all Game Objects
        /// </summary>
        public readonly GameGrid GameGrid;

        /// <summary>
        /// The map that contains all Game Objects
        /// </summary>
        public readonly Map Map = new Map();

        /// <summary>
        /// Initializes an instance of the Engine class.
        /// </summary>
        /// <param name="oopaGameGrid">The parent element of all game objects</param>
        public Engine(GameGrid oopaGameGrid)
        {
            this.GameGrid = oopaGameGrid;
            var images = Map.Images;

            foreach (var image in images)
            {
                GameGrid.Grid.Children.Add(image);
            }
        }

        /// <summary>
        /// The main game method that updates all the Game Objects
        /// </summary>
        public void Run()
        {
            Map.Update(GameGrid.Direction);
        }
    }
}
