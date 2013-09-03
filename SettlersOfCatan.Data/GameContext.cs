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

        public void SetPlayer(Data.PlayerData player)
        {
            var db = new GameContext();

            db.ListOfPlayers.Add(player);
            db.SaveChanges();
        }
    }
}
