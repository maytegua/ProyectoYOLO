using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    [Table("TipoVehiculo")]
    public class TipoVehiculo
    {
        [Key]
        public int TipoVehiculoId { get; set; }

        [Required]
        [StringLength(50,ErrorMessage = "Máximo de caracteres {0}",MinimumLength =2)]
        public string NombreTipoVehiculo { get; set; }

        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}