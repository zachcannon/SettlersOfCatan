using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Board
    {

        public List<String> ResourceTiles { get; private set; }
        public List<int> RollValueTiles { get; private set; }

        public Board()
        {
            ResourceTiles = GenerateResourceTiles();
            RollValueTiles = GenerateRollValueTiles();
        }

        private List<String> GenerateResourceTiles()
        {
            List<String> ResourceTiles_ = new List<String>() { "Wheat", "Wheat", "Wheat", "Wheat", "Sheep", "Sheep", "Sheep", "Sheep", "Wood", "Wood", "Wood", "Wood", "Ore", "Ore", "Ore", "Brick", "Brick", "Brick", "Desert" };
            return ResourceTiles_;
        }


        private List<int> GenerateRollValueTiles() {
            List<int> RollValueTiles_ = new List<int> {2,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,12};
            return RollValueTiles_;
        }

    }
}