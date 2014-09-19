using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace Hotels.Models
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("DBContext")
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
    }

    

   
    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña actual")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La contraseña debe se de al menos {2} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nueva contraseña")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nueva contraseña")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la confirmación de contraseña no coinciden.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginModel
    {
        [Required]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Display(Name = "Recordarme")]
        public bool RememberMe { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "El nombre debe ser de al menos {2} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre ")]
        public string UserName { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "El apellido debe ser de al menos {2} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellido")]
        public string UserLastName { get; set; }


        [Required]
        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Required]

        [Display(Name = "Telefono")]
        public string Telefono { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "La contraseña debe se de al menos {2} caracteres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
        public string ConfirmPassword { get; set; }
    }

    public class ModificacionModel
    {
        
        [Display(Name = "Nombre ")]
        public string UserName { get; set; }


        [Display(Name = "Apellido")]
        public string UserLastName { get; set; }


        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

    }
}
