using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameEngine.Interfaces;
using System.Windows.Controls;
using GameEngine.Enums;

namespace GameEngine.Models
{
    /// <summary>
    /// The Root object for all game items
    /// </summary>
    public abstract class GameObject : IDrawable
    {
        protected GameObject()
        {
            this.ObjectImage = new Image();
        }

        public string Name { get; set; }
        public Image ObjectImage { get; set; }
    }
}
