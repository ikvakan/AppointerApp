
using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
   public interface IServiceRepository :IRepository<Service>
    {

        IEnumerable<Service> GetServiceByServiceType(int idserviceType);

        IEnumerable<Service> GetServicesForCompany(int idCompany);
    }
}
