using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class ServiceTypeRepository : Repository<Service_Type>, IServiceTypeRepository
    {

        //private readonly ModelContainer _modelContainer;

       
        public ServiceTypeRepository(ModelContainer modelContainer) : base(modelContainer)
        {
            
        }

        public IEnumerable<Service_Type> GetServiceTypeForCompany(int idCompany)
        {
            return db.Service_Type.Where(s => s.CompanyIdCompany == idCompany).ToList();
        }
    }
}
