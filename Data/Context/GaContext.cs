using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class GaContext : DbContext
    {
        public DbSet<Garrafa> Garrafa { get; set; }
        public GaContext():base("Data Source=192.168.0.114;Initial Catalog=Felipe;Persist Security Info=True;User ID=Felipe;Password=#felipe")
        {

        }
    }
}
