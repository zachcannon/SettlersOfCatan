using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SettlersOfCatan.Models;

namespace SettlersOfCatan.Controllers
{
    public class StartGameController : Controller
    {
        
        public ActionResult DieRollPage()
        {
            Die dieToRoll = new Die();
            dieToRoll.rollDie();
            return View(dieToRoll);
        }

    }
}
