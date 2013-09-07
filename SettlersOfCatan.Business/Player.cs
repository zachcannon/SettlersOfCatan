using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlersOfCatan.Business
{
    public class Player
    {
        public int BrickResource { get; private set; }
        public int OreResource { get; private set; }
        public int SheepResource { get; private set; }
        public int WheatResource { get; private set; }
        public int WoodResource { get; private set; }

        public int PlayerId { get; private set; }

        public Player(int playerID)
        {
            this.PlayerId = playerID;
        }

        public Player(int playerID, int brickResource, int oreResource, int sheepResource, int wheatResource, int woodResource) 
        {
            this.PlayerId = playerID;
            this.BrickResource = brickResource;
            this.OreResource = oreResource;
            this.SheepResource = sheepResource;
            this.WheatResource = wheatResource;
            this.WoodResource = woodResource;
        } 

        public void ChangeBrickResource(int brick)
        {
            BrickResource += brick;
        }       

        public void ChangeOreResource(int ore)
        {
            OreResource += ore;
        }

        public void ChangeSheepResource(int sheep)
        {
            SheepResource += sheep;
        }

        public void ChangeWheatResource(int wheat)
        {
            WheatResource += wheat;
        }

        public void ChangeWoodResource(int wood)
        {
            WoodResource += wood;
        }
    }
}
