using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class ServicesSessionModel
    {
        public List<Service> Services{ get; set; }


        public ServicesSessionModel()
        {
            Services = new List<Service>();
        }
        public int GetSubtotal()
        {
            int total = 0;

            foreach (var item in Services)
            {
                total += item.Price;
            }

            return total;
        }


        public int GetDuration()
        {
            int total = 0;
            foreach (var item in Services)
            {
                total += item.Duration;
            }

            return total;
        }
    }
}