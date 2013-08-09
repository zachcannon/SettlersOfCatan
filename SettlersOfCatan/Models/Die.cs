using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Die
    {
        public int LastRollValue { get; set; }

        public void Roll()
        {
            Random randomOne = new Random();
            Random randomTwo = new Random(randomOne.Next());
            LastRollValue += randomOne.Next(1, 7);
            LastRollValue += randomTwo.Next(1, 7);
        }
    }
}