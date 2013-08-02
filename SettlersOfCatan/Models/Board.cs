using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Board
    {
        enum Terrains
        {
            Desert,
            Ore,
            Brick,
            Wood,
            Wheat,
            Sheep
        };

        public List<String> TerrainTiles { get; private set; }
        public List<int> NumberTokens { get; private set; }

        public Board()
        {
            TerrainTiles = GenerateTerrainTiles();
            NumberTokens = GenerateNumberTokens();
        }

        private List<String> GenerateTerrainTiles()
        {
            IEnumerable<Terrains> terrainTiles = new List<Terrains>
            {
                Terrains.Desert,
                Terrains.Ore,
                Terrains.Ore,
                Terrains.Ore,
                Terrains.Brick,
                Terrains.Brick,
                Terrains.Brick,
                Terrains.Wood,
                Terrains.Wood,
                Terrains.Wood,
                Terrains.Wood,
                Terrains.Wheat,
                Terrains.Wheat,
                Terrains.Wheat,
                Terrains.Wheat,
                Terrains.Sheep,
                Terrains.Sheep,
                Terrains.Sheep,
                Terrains.Sheep
            };

            var random = new Random();
            terrainTiles = terrainTiles.OrderBy(t => random.Next());

            return terrainTiles.Select<Terrains, String>(t => t.ToString()).ToList();
        }


        private List<int> GenerateNumberTokens()
        {
            List<int> numberTokens = new List<int> { 2, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 12 };
            return numberTokens;
        }
    }
}