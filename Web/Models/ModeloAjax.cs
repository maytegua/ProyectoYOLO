using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Web.Models
{
    [Table("ModeloAjaxExample")]
    public class ModeloAjax
    {
        [Key]
        public int ModeloId { get; set; }

        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string LastName { get; set; }

    }
}