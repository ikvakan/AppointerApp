using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ServiceModel
    {
        public int IdService { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public int Service_TypeIdServiceType { get; set; }

    }
}