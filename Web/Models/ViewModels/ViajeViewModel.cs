﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models.ViewModels
{
    public class ViajeViewModel
    {
        public int ViajeId { get; set; }

        [Display(Name = "Fecha de Publicación")]
        public DateTime Fecha { get; set; }

        [Display(Name = "Usuario Piloto")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "Punto de Partida")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string PuntoPartida { get; set; }

        [Display(Name = "Punto de Destino")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string PuntoDestino { get; set; }

        [Display(Name = "Fecha de Salida")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Date)]
        public string FechaSalida { get; set; }

        [Display(Name = "Hora de Salida")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Time)]
        public string HoraSalida { get; set; }

        [Display(Name = "Fecha de Regreso")]
        [DataType(DataType.Date)]
        public string FechaRegreso { get; set; }

        [Display(Name = "Hora de Regreso")]
        [DataType(DataType.Time)]
        public string HoraRegreso { get; set; }

        [Display(Name = "Tarifa Pasajeros")]
        [Required(ErrorMessage = "El campo {0} es requerido")]    
        public double Tarifa { get; set; }

        [Display(Name = "Asientos Disponibles")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int NumAsientos { get; set; }

        [Display(Name = "Detalles del viaje")]
        //[Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.MultilineText)]
        public string DetallesViaje { get; set; }

        [Display(Name = "Tipo de Vehículo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int TipoVehiculoId { get; set; }
        //propiedad virtual para la relacion Viaje/TipoVehiculo
        public virtual TipoVehiculo TipoVehiculo { get; set; }
    }
}