using causerita.repositorio.Inicializacao;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public static class Inicializador
    {
        public static void InicializarBanco()
        {
            Database.SetInitializer<CauseritaContext>(new CauseritaInicializadorDB());
        }
    }
}
