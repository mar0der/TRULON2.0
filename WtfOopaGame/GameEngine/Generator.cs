using GameEngine.Models.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    /// <summary>
    /// Generates all need collections
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// Generates the map areas
        /// </summary>
        /// <param name="map">The parent object of the areas</param>
        /// <returns>Collection of areas</returns>
        internal static List<Area> GetMapAreas(Map map)
        {
            var areas = new List<Area>();

            throw new NotImplementedException();

            return areas;
        }

        /// <summary>
        /// Generates map with the correct image and size
        /// </summary>
        /// <returns>the needed map</returns>
        internal static Map GetMap()
        {
            var map = new Map();

            throw new NotImplementedException();

            return map;
        }
    }
}
