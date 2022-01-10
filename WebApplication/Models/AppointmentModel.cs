using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class AppointmentModel
    {
        public int IdAppointment { get; set; }
        public string Naziv { get; set; }
        [Display(Name = "Odaberite datum rezervacije")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [Display(Name = "Odaberite vrijeme")]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }
        [Display(Name = "Dodatna napomena")]
        public string DodatnaNapomena { get; set; }
    }
}