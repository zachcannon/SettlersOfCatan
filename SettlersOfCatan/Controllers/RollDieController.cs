using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SettlersOfCatan.Models;

namespace SettlersOfCatan.Controllers
{
    public class RollDieController : Controller
    {

        public ActionResult DieRollPage()
        {
            return View();
        }

        public string GetDieRoll()
        {
            Die die = new Die();
            die.rollDie();
            return ("The last roll was a " + die.DieValue);
        }

    }
}
