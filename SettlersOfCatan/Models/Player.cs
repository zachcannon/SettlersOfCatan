using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Player
    {
        public int WoodResource { get; private set; }
        public int SheepResource { get; private set; }
        public int OreResource { get; private set; }
        public int BrickResource { get; private set; }
        public int WheatResource { get; private set; }

        public int PlayerNumber{ get; set; }

        public Player()
        {
            this.SetResourcesToEmpty();
        }

        private void SetResourcesToEmpty()
        {
            BrickResource = 0;
            OreResource = 1;
            SheepResource = 3;
            WheatResource = 4;
            WoodResource = 8;
        }

        public void ChangeWoodResource(int wood)
        {
            WoodResource += wood;
        }

        public void ChangeOreResource(int ore)
        {
            OreResource += ore;
        }

        public void ChangeBrickResource(int brick)
        {
            BrickResource += brick;
        }

        public void ChangeWheatResource(int wheat)
        {
            WheatResource += wheat;
        }

        public void ChangeSheepResource(int sheep)
        {
            SheepResource += sheep;
        }
    }
}