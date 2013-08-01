using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Die
    {
        public int DieValue { get; private set; }

        public void Roll()
        {
            Random random = new Random();
            this.DieValue = random.Next(1, 7);
        }
    }
}