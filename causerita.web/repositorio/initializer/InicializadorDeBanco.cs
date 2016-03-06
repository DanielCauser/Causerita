using repositorio.contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio.initializer
{
    public class InicializadorDeBanco : DropCreateDatabaseAlways<ContextoCauserita>
    {

        protected override void Seed(ContextoCauserita context)
        {
            var vendedores = new List<Vendedor>
            {
                new Vendedor
                {
                    Nome = "Fulana Ciclana"
                },
                new Vendedor
                {
                    Nome = "Fulana Xinforunpula"
                }
            };



            vendedores.ForEach(s =>
                context.Vendedor.Add(s));
            context.SaveChanges();

        }


    }
}
