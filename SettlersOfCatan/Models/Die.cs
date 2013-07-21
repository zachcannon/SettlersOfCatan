using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Die
    {
        public int dieValue { get; set; }

        public void rollDie()
        {
            Random random = new Random();
            this.dieValue = random.Next(1, 7);
        }
    }
}