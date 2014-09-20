using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Web.Security;
using Hotels.Models;

namespace Hotels.Models
{
    public class Reserva
    {
        public int ID { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de llegada")]
        public DateTime StartDate { get; set; }

<<<<<<< HEAD

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de partida")]
=======
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha terminación")]
>>>>>>> origin/master
        public DateTime EndDate { get; set; }

        public int HabitacionID { get; set; }
        public int UsuarioID { get; set; }
        public virtual Habitacion Habitacion { get; set; }


        public virtual UserProfile usuario { get; set; }

    }

}
   
    
