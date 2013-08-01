using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Board
    {
        public List<String> ResourceTiles { get; private set; }
        public List<int> NumberTokens { get; private set; }

        public Board()
        {
            ResourceTiles = GenerateResourceTiles();
            NumberTokens = GenerateNumberTokens();
        }

        private List<String> GenerateResourceTiles()
        {
            List<String> resourceTiles = new List<String>();
            for (int i = 0; i < 19; i++)
            {
                Random random = new Random(i);
                int value = random.Next(1,7);
                if (value == 1) resourceTiles.Add("Wheat");
                else if (value == 2) resourceTiles.Add("Sheep");
                else if (value == 3) resourceTiles.Add("Wood");
                else if (value == 4) resourceTiles.Add("Ore");
                else if (value == 5) resourceTiles.Add("Brick");
                else if (value == 6) resourceTiles.Add("Desert");
            }

            return resourceTiles;
        }


        private List<int> GenerateNumberTokens() {
            List<int> numberTokens = new List<int> {2,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,12};
            return numberTokens;
        }

    }
}