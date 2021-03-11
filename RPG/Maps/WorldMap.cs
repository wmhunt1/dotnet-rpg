using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class WorldMap : Map
    {
        private String _mapName = "World Map";
        public override String mapName { get { return _mapName; } set { _mapName = value; } }

         override public void ViewMap()
        {
            Console.WriteLine("Viewing World Map");
        }
    }
}