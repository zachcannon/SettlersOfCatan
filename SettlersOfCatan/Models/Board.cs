using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Board
    {

        public List<String> Tiles { get; private set; }

        public Board()
        {
            Tiles = new List<String>() { "Wheat", "Wheat", "Wheat", "Wheat", "Sheep", "Sheep", "Sheep", "Sheep", "Wood", "Wood", "Wood", "Wood", "Ore", "Ore", "Ore", "Brick", "Brick", "Brick", "Desert" };
        }

    }
}