using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace causerita.repositorio.Modelo
{
    public class VendedorModel
    {
        [Key]
        public Guid VendedorId { get; set; }
        
        public string Nome { get; set; }
    }
}
