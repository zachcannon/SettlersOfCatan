using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SettlersOfCatan.Models
{
    public class Player
    {
        public int BrickResource { get; set; }
        public int SheepResource { get; set; }
        public int StoneResource { get; set; }
        public int WheatResource { get; set; }
        public int WoodResource { get; set; }
    }
}