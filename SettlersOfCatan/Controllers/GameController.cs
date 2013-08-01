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

        public ActionResult CreateAndGetBoard()
        {
            Board board = new Board();
            return Json(board.ResourceTiles, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Instance()
        {
            return View();
        }
    }
}
