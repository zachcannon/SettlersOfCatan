using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Board
    {
        public List<String> TerrainTiles { get; private set; }
        public List<int> NumberTokens { get; private set; }

        public Board()
        {
            TerrainTiles = GenerateTerrainTiles();
            NumberTokens = GenerateNumberTokens();
        }

        private List<String> GenerateTerrainTiles()
        {
            List<String> terrainTiles = new List<String>();
            for (int i = 0; i < 19; i++)
            {
                Random random = new Random(i);
                int value = random.Next(1,7);
                if (value == 1) terrainTiles.Add("Wheat");
                else if (value == 2) terrainTiles.Add("Sheep");
                else if (value == 3) terrainTiles.Add("Wood");
                else if (value == 4) terrainTiles.Add("Ore");
                else if (value == 5) terrainTiles.Add("Brick");
                else if (value == 6) terrainTiles.Add("Desert");
            }

            return terrainTiles;
        }


        private List<int> GenerateNumberTokens() {
            List<int> numberTokens = new List<int> {2,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,12};
            return numberTokens;
        }

    }
}