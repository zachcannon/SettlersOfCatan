﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SettlersOfCatan.Models
{
    public class PlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}