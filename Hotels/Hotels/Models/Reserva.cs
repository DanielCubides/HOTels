using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Globalization;
using System.Web.Security;

namespace Hotels.Models
{
    public class Reserva
    {
        public int ID { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha inicio")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha terminación")]
        public DateTime EndDate { get; set; }

        public int HabitacionID { get; set; }
        public virtual Habitacion Habitacion { get; set; }
        public virtual UserProfile usuario { get; set; }

    }


   
    
}