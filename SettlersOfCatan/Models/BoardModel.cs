using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class BoardModel
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

        public int DesertLocation { get; set; }

        public List<TileModel> TerrainTiles { get; private set; }

        public BoardModel()
        {
            List<String> TerrainTileTypes = GenerateTerrainTileTypes();
            FindDesertLocation(TerrainTileTypes);
            List<int> NumberTokenTiles = GenerateNumberTokens(TerrainTileTypes);
            TerrainTiles = GenerateBoard(TerrainTileTypes, NumberTokenTiles);
        }

        private void FindDesertLocation(List<String> terrainTileTypes)
        {
            DesertLocation = terrainTileTypes.IndexOf("Desert");
        }

        private List<String> GenerateTerrainTileTypes()
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


        private List<int> GenerateNumberTokens(List<String> terrainTileTypes)
        {
            List<int> numberTokenTiles = new List<int> { 5, 2, 6, 10, 9, 4, 3, 8, 11, 5, 8, 4, 3, 6, 10, 11, 12, 9};
            numberTokenTiles.Insert(DesertLocation, 0);
            return numberTokenTiles;
        }

        private List<TileModel> GenerateBoard(List<String> terrainTileTypes, List<int> numberTokenTiles)
        {
            List<TileModel> TerrainTiles = new List<TileModel>();

            for (int i = 0; i < terrainTileTypes.Count(); i++)
            {
                TerrainTiles.Add(new TileModel(numberTokenTiles[i], terrainTileTypes[i]));
            }

            return TerrainTiles;
        }
    }
}