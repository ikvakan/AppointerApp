using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ClientModel
    {

        public int IdClient { get; set; }

        [Required(ErrorMessage ="Korisničko ime je obavezno."),Display(Name ="Korisničko ime")]
        public string UserName { get; set; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Lozinka je obavezna."),Display(Name="Lozinka"),]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Lozinke se ne podudaraju."),Display(Name ="Potvrdite lozinku")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Ime je obavezno."),Display(Name = "Ime")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Prezime je obavezno."),Display(Name = "Prezime")]
        public string Surname { get; set; }
        [Display (Name ="E-mail")]
        [Required(ErrorMessage = "Email je obavezan."), EmailAddress(ErrorMessage = "Neispravan Email.")]
        public string Email { get; set; }
        [Required (ErrorMessage ="Kontakt obavezan."), RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format kontakta."),Display(Name ="Kontakt")]
        public string Contact { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format oib-a."), StringLength(11, ErrorMessage = "Oib mora sadržavati 11 znakova")]
        public string OIB { get; set; }

        [Required(ErrorMessage ="Adresa je obavezna."),Display(Name ="Adresa")]
        public string Adress { get; set; }
        [Required(ErrorMessage ="Grad je obavezan."),Display(Name ="Grad")]
        public string City { get; set; }

        [Required(ErrorMessage ="Obavezna stavka."),Display(Name = "Prihvaćam odredbe i uvjete")]
        public bool  AcceptTearmsAndConditions { get; set; }

    }
}