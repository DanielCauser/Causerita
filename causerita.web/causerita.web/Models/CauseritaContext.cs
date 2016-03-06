using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace causerita.web.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class CauseritaContext : DbContext
    {
        public CauseritaContext():base("Desenv")
        {

        }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}