
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
    public interface IServiceTypeRepository :IRepository<Service_Type>
    {
        IEnumerable<Service_Type> GetServiceTypeForCompany(int idCompany);
        

        
    }
}
