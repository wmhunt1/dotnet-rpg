using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Map
    {
        private String _mapName;
        public virtual String mapName { get { return _mapName; } set { _mapName = value; } }
        public virtual void DisplayMapName()
        {
            
            Console.Write($"{this.mapName}\n");
        }

        public virtual void ViewMap()
        {
            Console.WriteLine("Viewing Map");
        }

    }
}