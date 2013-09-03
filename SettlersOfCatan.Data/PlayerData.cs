using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan.Data
{
    public class PlayerData
    {
        public int BrickResource { get; private set; }
        public int OreResource { get; private set; }
        public int SheepResource { get; private set; }
        public int WheatResource { get; private set; }
        public int WoodResource { get; private set; }

        public int id { get; private set; }

        public PlayerData(int playerID, int brickResource, int oreResource, int sheepResource, int wheatResource, int woodResource)
        {
            this.id = playerID;
            this.BrickResource = brickResource;
            this.OreResource = oreResource;
            this.SheepResource = sheepResource;
            this.WheatResource = wheatResource;
            this.WoodResource = woodResource;
        }
        
    }
}
