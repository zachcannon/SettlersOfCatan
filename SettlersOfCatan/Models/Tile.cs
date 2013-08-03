using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Tile
    {
        public int NumberTokenValue { get; set; }
        public string TerrainType { get; set; }
        public bool HasNumberToken { get; set; }

        public Tile(int numberTokenValue, string terrainType)
        {
            this.NumberTokenValue = numberTokenValue;
            this.TerrainType = terrainType;
            this.HasNumberToken = true;
        }

        public Tile(string terrainType)
        {
            this.TerrainType = terrainType;
            this.HasNumberToken = false;
        }

    }
}