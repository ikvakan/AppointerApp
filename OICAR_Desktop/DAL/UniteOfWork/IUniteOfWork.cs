using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL.Interfaces
{
    public interface IUniteOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IServiceRepository Services { get; }
        IWorkerRepository  Workers { get; }
       
        IServiceTypeRepository ServiceTypes { get; }

        IApponitmentRepository Apponitments { get; }

        IStatusRepository Status { get; }

        int SaveChanges();
    }
}
