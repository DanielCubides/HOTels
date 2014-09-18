using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Hotels.Models
{
    public class Habitacion
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El nombre debe ser de al menos {2} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Disponible")]
        public bool Avalible { get; set; }
        [Required]
        [Display(Name = "Fecha Inialización")]
        public DateTime StarDate { get; set; }
        [Required]
        [Display(Name = "Fecha Finalización")]
        public DateTime EndDate { get; set; }
        [Required]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }
        public virtual ICollection<Reserva> Reserva { get; set; }

    }

}