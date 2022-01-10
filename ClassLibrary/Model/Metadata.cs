using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class ClientMD
    {
        [Required(ErrorMessage ="Ime je obavezno.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Prezime je obavezno.")]
        public string Surname { get; set; }
        [Required(ErrorMessage ="Email je obavezan."),EmailAddress(ErrorMessage ="Neispravan Email.")]
        public string Email { get; set; }
        [Required, RegularExpression("^[0-9]*$",ErrorMessage ="Neispravan format kontakta.")]
        public string Contact { get; set; }
        
        [RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format oib-a.")]
        public string OIB { get; set; }

        public string Adress { get; set; }
       
        public string City { get; set; }

    }

    public class ServiceMD
    {   
        [Required(ErrorMessage ="Naziv obavezan.")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Cijena obavezna."), RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format.")]
        public int Price { get; set; }
      
    }

    public class WorkerMD
    {
      //  public int IdWorker { get; set; }

        [Required(ErrorMessage = "Ime je obavezno.")]
        
        public string Name { get; set; }
        [Required(ErrorMessage = "Prezime je obavezno.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email je obavezan."), EmailAddress(ErrorMessage = "Neispravan Email.")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Kontak je obavezan."), RegularExpression("^[0-9]*$", ErrorMessage = "Neispravan format kontakta.")]
        public string Contact { get; set; }
    }
   
    
    public class Service_TypeMD
    {
        [Required(ErrorMessage = "Vrsta usluge je obavezan.")]

        public string Name { get; set; }
    } 
    public class ApponitmentMD
    {
        
    }


    public class CompanyMD
    {
        [Display(Name ="Naziv")]
        [Required(ErrorMessage ="Naziv je obavezan")]
        public string Name { get; set; }
        [Display(Name = "Adresa")]

        [Required(ErrorMessage ="Adresa je obavezna")]
        public string Adress { get; set; }
        [Display(Name = "Grad")]

        [Required(ErrorMessage = "Grad je obavezan")]

        public string City { get; set; }
        [Display(Name = "Eamil")]

        [Required(ErrorMessage = "Email je obavezan"),EmailAddress(ErrorMessage ="Neispravan email")]

        public string Email { get; set; }
        [Display(Name = "Kontakt")]

        [Required(ErrorMessage = "Kontakt je obavezan"), RegularExpression("^[0-9]*$",ErrorMessage ="Pogrešan format kontakta (samo brojevi)")]

        public string Contact { get; set; }
        [Display(Name = "Opis")]

        [Required(ErrorMessage = "Opis je obavezan")]

        public string Description { get; set; }
             
    }

    public class Working_HoursMD
    {

    }
}
