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
            List<String> ResourceTiles_ = new List<String>();
            for (int i = 0; i < 19; i++)
            {
                Random random = new Random(i);
                int value = random.Next(1,7);
                if (value == 1) ResourceTiles_.Add("Wheat");
                else if (value == 2) ResourceTiles_.Add("Sheep");
                else if (value == 3) ResourceTiles_.Add("Wood");
                else if (value == 4) ResourceTiles_.Add("Ore");
                else if (value == 5) ResourceTiles_.Add("Brick");
                else if (value == 6) ResourceTiles_.Add("Desert");
            }

            return ResourceTiles_;
        }


        private List<int> GenerateNumberTokens() {
            List<int> NumberTokens_ = new List<int> {2,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,12};
            return NumberTokens_;
        }

    }
}