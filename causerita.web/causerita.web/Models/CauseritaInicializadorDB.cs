using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace causerita.web.Models
{
    public class CauseritaInicializadorDB : DropCreateDatabaseAlways<CauseritaContext>
    {
        protected override void Seed(CauseritaContext context)
        {
            var vendedores = new List<Vendedor>
            {
                new Vendedor
                {
                    VendedorId = Guid.NewGuid(),
                    Nome = "Jovem jovial"
                },
                new Vendedor
                {
                    VendedorId = Guid.NewGuid(),
                    Nome = "James Bond"
                }
            };
            vendedores.ForEach(s =>
            context.Vendedor.Add(s));
            context.SaveChanges();
        }
    }
}