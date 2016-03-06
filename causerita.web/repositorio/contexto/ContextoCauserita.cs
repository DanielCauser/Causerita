using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio.contexto
{
    public class ContextoCauserita : DbContext
    {
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}
