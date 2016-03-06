using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace causerita.web.Models
{
    public class Vendedor
    {
        [Key]
        public Guid VendedorId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Nome Vendedora")]
        public string Nome { get; set; }
    }
}