using causerita.repositorio.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace causerita.repositorio.Inicializacao
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class CauseritaContext : DbContext
    {
        public CauseritaContext() : base("Desenv")
        {

        }
        public DbSet<VendedorModel> Vendedor { get; set; }
    }
}
