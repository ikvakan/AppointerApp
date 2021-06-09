using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.Model
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
   
    //public class SpecializationMD
    //{
    //    [Required(ErrorMessage = "Specijalizacija je obavezan.")]

    //    public string Name { get; set; }
    //}
    public class Service_TypeMD
    {
        [Required(ErrorMessage = "Vrsta usluge je obavezan.")]

        public string Name { get; set; }
    } 
    public class ApponitmentMD
    {
        
    }
}
