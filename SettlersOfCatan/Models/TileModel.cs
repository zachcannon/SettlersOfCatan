using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class TileModel
    {
        public int NumberTokenValue { get; set; }
        public string TerrainType { get; set; }
        public bool HasNumberToken { get { return (NumberTokenValue >= 2 && NumberTokenValue <= 12); } }

        public TileModel(int numberTokenValue, string terrainType)
        {
            this.NumberTokenValue = numberTokenValue;
            this.TerrainType = terrainType;
        }
    }
}