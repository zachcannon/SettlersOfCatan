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

        public int PlayerId{ get; set; }

        public Player(int playerId)
        {
            this.SetResourcesToEmpty(playerId);
        }

        private void SetResourcesToEmpty(int playerId)
        {
            BrickResource = playerId;
            OreResource = playerId;
            SheepResource = playerId;
            WheatResource = playerId;
            WoodResource = playerId;
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