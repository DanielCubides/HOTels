using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hotels.Models
{
    public class Reserva
    {
        public int ID { get; set; }
        public UserProfile User { get; set; }
        public Habitacion Habitacion { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class ReservaDBContext : DbContext
    {
        public DbSet<Reserva> Reservas { get; set; }
    }
}