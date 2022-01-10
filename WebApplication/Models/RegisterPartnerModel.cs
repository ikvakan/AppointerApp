using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class RegisterPartnerModel
    {
        public int IdCompanyLogin { get; set; }
        [Display(Name="Ime")]
        [Required(ErrorMessage ="Ime obavezno.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Prezime obavezno.")]
        [Display(Name="Prezime")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Korisničko ime obavezno"),Display(Name ="Korisničko ime")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lozinka obavezna.")]
        [Display(Name ="Lozinka")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name="Ponovite lozinku")]
        [DataType(DataType.Password),Compare("Password",ErrorMessage ="Lozinke se ne podudaraju.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email obavezan."),EmailAddress(ErrorMessage ="Neispravan email.")]
        [Display(Name="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Kontakt obavezan.")]
        [Display(Name ="Kontakt"), RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format kontakta.")]
        public string Contact { get; set; }

    }
}