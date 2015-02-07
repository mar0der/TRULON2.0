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

namespace GameEngine.CoreLogic
{
    class Engine
    {
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
            List<Item> items = new List<Item>();
            items.Add(new Axe());
        }
    }
}
