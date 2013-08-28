using SettlersOfCatan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SettlersOfCatan.Controllers
{
    public class GameController : Controller
    {
        public ActionResult SettlersGame()
        {
            return View();
        }

        public ActionResult CreateBoard()
        {
            Board board = new Board();
            return Json(board, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RollDie()
        {
            Die die = new Die();
            die.Roll();
            return Json(die.LastRollValue, JsonRequestBehavior.AllowGet);
        }

        public void CreatePlayers()
        {
            using (var db = new PlayerContext())
            {
                Player player1 = new Player(1);
                Player player2 = new Player(2);
                Player player3 = new Player(3);
                Player player4 = new Player(4);
                db.Players.Add(player1);
                db.Players.Add(player2);
                db.Players.Add(player3);
                db.Players.Add(player4);
                db.SaveChanges();
                
            }
        }

        public ActionResult GetPlayerResources(int input)
        {

            Player player = new Player(input);
            return Json(player, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Instance()
        {
            return View();
        }
    }
}
