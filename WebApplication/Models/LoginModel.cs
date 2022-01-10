using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Korisničko ime obavezno"),Display(Name ="Korisničko ime")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lozinka obavezna"),Display(Name ="Lozinka")]
        public string Password { get; set; }

    }
}