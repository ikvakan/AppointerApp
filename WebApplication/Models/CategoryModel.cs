using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class CategoryModel
    {

      
        public int IdCategory { get; set; }
        [Display(Name = "Kategorija tvrtke")]
        public string CategoryName { get; set; }


    }
}