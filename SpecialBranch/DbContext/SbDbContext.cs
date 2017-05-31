using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using SpecialBranch.Models;

namespace SpecialBranch.DbContext
{
    public class SbDbContext:System.Data.Entity.DbContext
    {
        public DbSet<Rpo> Rpos { get; set; }
        public DbSet<RpoLogin> RpoLogins { get; set; }
        public DbSet<SbDsb> SbDsb { get; set; }
        public DbSet<SbDispatch> SbDispatches { get; set; }
        public DbSet<SbReceive> SbReceives { get; set; }
    }
}