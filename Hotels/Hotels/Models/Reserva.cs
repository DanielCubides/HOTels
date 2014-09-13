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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HabitacionID { get; set; }
        public virtual Habitacion Habitacion { get; set; }
        public virtual UserProfile usuario { get; set; }

    }

}