using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Causerita.web.Models
{
    public class Vendedor
    {
        public Guid VendedorId { get; set; }

        [Required]
        public string Nome { get; set; }
    }
}