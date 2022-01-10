using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class UserAccountModel
    {
        public UserAccountModel()
        {
            Client = new ClientModel();
        }

        public int IdClientGDPR { get; set; }
        public bool AuthorizePersonlaInformation { get; set; }
        public bool TargetedAdvertisement { get; set; }
        public bool AccessDeviceData { get; set; }

        public ClientModel Client { get; set; }

    }
}