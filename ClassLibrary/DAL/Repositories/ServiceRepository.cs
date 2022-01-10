using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary.DAL
{
    public class ServiceRepository : Repository<Service>, IServiceRepository
    {
     

        public ServiceRepository(ModelContainer modelContainer) : base(modelContainer)
        {
           
        }

        public IEnumerable<Service> GetServiceByServiceType(int idserviceType)
        {
            return db.Service.Where(s => s.Service_TypeIdServiceType == idserviceType).ToList();
        }

        public IEnumerable<Service> GetServicesForCompany(int idCompany)
        {
            List<Service> services = new List<Service>();
            var serviceTypes = db.Service_Type.Where(st => st.CompanyIdCompany == idCompany).ToList();
            
            foreach (var item in serviceTypes)
            {

                var service = db.Service.FirstOrDefault(s => s.Service_TypeIdServiceType == item.IdServiceType);
                services.Add(service);
            }

            return services;
        }
    }
}
