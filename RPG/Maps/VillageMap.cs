using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class VillageMap : Map
    {
        private String _mapName = "The Village of Dale";
        public override String mapName { get { return _mapName; } set { _mapName = value; } }

        override public void ViewMap()
        {
            Console.WriteLine("Viewing The Village of Dale Map");
        }
    }
}