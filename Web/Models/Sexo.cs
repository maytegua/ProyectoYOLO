using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    [Table("Sexo")]
    public class Sexo
    {
        [Key]
        public int SexoId { get; set; }

        public string Nombre { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
    }
}