using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class ServiceTypeModel
    {
        public int IdServiceType { get; set; }
        public string Name { get; set; }

        public IEnumerable<SelectListItem> ServiceTypes { get; set; }
        public IEnumerable<string> SelectedServiceType { get; set; }


    }
}