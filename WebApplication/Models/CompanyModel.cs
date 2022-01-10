using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication.Models
{
    public class CompanyModel
    {

     
        public int IdCompany { get; set; }

        [Required(ErrorMessage ="Naziv obavezan."),Display(Name ="Naziv tvrtke")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Adresa obavezna."), Display(Name = "Adresa")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Grad obavezan."), Display(Name = "Grad")]
        public string City { get; set; }
        [Required(ErrorMessage = "Email obavezan."), Display(Name = "Email"),EmailAddress(ErrorMessage ="Neispravan email.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Kontakt obavezan."), Display(Name = "Kontakt"), RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format kontakta.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Opis obavezan."), Display(Name = "Opis")]

        public string Description { get; set; }


        public int IdCategory { get; set; }


        [ Display(Name = "Kategorija tvrtke")]

        public string CategoryName { get; set; }

    }
}