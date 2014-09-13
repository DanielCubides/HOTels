using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Hotels.Models
{
    public class Habitacion
    {
        public int ID { get; set; }
        public bool Avalible { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }

        public ICollection<Reserva> Reserva { get; set; }
    }

    public class HabitacionDBContext : DbContext
    {
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}