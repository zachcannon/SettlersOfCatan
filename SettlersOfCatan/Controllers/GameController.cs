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

        public ActionResult GetPlayerInfo()
        {
            Player player = new Player();
            return Json(player, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Instance()
        {
            return View();
        }
    }
}
