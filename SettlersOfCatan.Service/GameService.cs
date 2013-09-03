using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SettlersOfCatan.Business;
using SettlersOfCatan.Data;

namespace SettlersOfCatan.Service
{
    public class GameService
    {
        public GameService() { }

        public void AddNewPlayerToDB(int playerId)
        {
            Business.Player playerToAdd = new Business.Player(playerId);
            Data.PlayerData player = new Data.PlayerData(playerToAdd.PlayerId, playerToAdd.BrickResource, playerToAdd.OreResource, playerToAdd.SheepResource, playerToAdd.WheatResource, playerToAdd.WoodResource);

            Data.GameContext context = new Data.GameContext();
            context.SetPlayer(player);
        }    
    }
}
