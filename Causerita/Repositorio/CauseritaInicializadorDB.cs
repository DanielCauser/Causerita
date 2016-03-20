using causerita.repositorio.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace causerita.repositorio.Inicializacao
{
    public class CauseritaInicializadorDB : DropCreateDatabaseAlways<CauseritaContext>
    {
        protected override void Seed(CauseritaContext context)
        {
            var vendedores = new List<VendedorModel>
            {
                new VendedorModel
                {
                    VendedorId = Guid.NewGuid(),
                    Nome= "jovem jovial"
                },
                new VendedorModel
                {
                    VendedorId= Guid.NewGuid(),
                    Nome= "james bond"
                }
            };
            vendedores.ForEach(s =>
            context.Vendedor.Add(s));
            context.SaveChanges();
        }
    }
}
