using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SettlersOfCatan.Controllers
{
    public class GameController : Controller
    {

        //Display 4 Players with with Resources below

        public ActionResult SettlersGame()
        {
            return View();
        }

    }
}
