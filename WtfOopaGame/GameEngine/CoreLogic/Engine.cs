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

namespace GameEngine.CoreLogic
{
    public class Engine
    {
        public readonly GameGrid GameGrid;

        public Engine(GameGrid oopaGameGrid)
        {
            this.GameGrid = oopaGameGrid;
        }

        public object InitializeEngine()
        {
            throw new NotImplementedException();
        }

        public object GetAllImages()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            //To Do - implement update functionality
        }
    }
}
