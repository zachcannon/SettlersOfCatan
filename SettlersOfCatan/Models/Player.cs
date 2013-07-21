using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Player
    {
        public Player()
        {
            brickResource = 0;
            sheepResource = 0;
            stoneResource = 0;
            wheatResource = 0;
            woodResource = 0;
            victoryPoints = 0;
        }

        public int brickResource { get; set; }
        public int sheepResource { get; set; }
        public int stoneResource { get; set; }
        public int wheatResource { get; set; }
        public int woodResource { get; set; }

        public int victoryPoints { get; set; }
    }
}