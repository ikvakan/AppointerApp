using OICAR_Desktop.DAL.Interfaces;
using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL
{
    public class ServiceTypeRepository : Repository<Service_Type>, IServiceTypeRepository
    {
        public ServiceTypeRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }
    }
}
