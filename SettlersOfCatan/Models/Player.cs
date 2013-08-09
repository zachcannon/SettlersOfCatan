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

        public Player(int playerNumber)
        {
            this.PlayerNumber = playerNumber;
            this.SetResourcesToEmpty();
        }

        private void SetResourcesToEmpty()
        {
            WoodResource = 0;
            SheepResource = 0;
            BrickResource = 0;
            OreResource = 0;
            WheatResource = 0;
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