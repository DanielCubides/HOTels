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
        public bool Avalible { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
<<<<<<< HEAD
        public virtual ICollection<Reserva> Reserva { get; set; }
=======

        public ICollection<Reserva> Reserva { get; set; }
>>>>>>> origin/master
    }

}