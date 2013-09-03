using SettlersOfCatan.Models;
using SettlersOfCatan.Business;
using SettlersOfCatan.Service;
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
            BoardModel board = new BoardModel();
            return Json(board, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RollDie()
        {
            DieModel die = new DieModel();
            die.Roll();
            return Json(die.LastRollValue, JsonRequestBehavior.AllowGet);
        }

        public void CreatePlayers()
        {
            Service.GameService service = new Service.GameService();
            service.AddNewPlayerToDB(1);
            service.AddNewPlayerToDB(2);
            service.AddNewPlayerToDB(3);
            service.AddNewPlayerToDB(4);
        }

        public ActionResult GetPlayerResources(int input)
        {
            Business.Player player = new Business.Player(input);
            return Json(player, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult Instance()
        {
            return View();
        }
    }
}
