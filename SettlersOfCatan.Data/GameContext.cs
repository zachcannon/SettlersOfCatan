using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SettlersOfCatan.Data{

    public class GameContext : DbContext
    {
        public GameContext() { }

        public DbSet<PlayerData> ListOfPlayers { get; set; }

        public void SetPlayer(Data.PlayerData newPlayerData)
        {
            var db = new GameContext();

            var player = db.ListOfPlayers.Find(newPlayerData.Id);

            if (player == null)
            {
                db.ListOfPlayers.Add(newPlayerData);
                db.SaveChanges();
            }
            else
            {
                db.Entry(player).CurrentValues.SetValues(newPlayerData);
                db.SaveChanges();
            }            
        }
    }
}
