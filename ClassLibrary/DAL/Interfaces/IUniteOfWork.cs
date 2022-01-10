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
        ISpecializationRepository Specializations { get; }

        IServiceTypeRepository ServiceTypes { get; }

        IWorkerSpecializationRepository WorkerSpecializations { get; }

        IApponitmentRepository Apponitments { get; }

        int SaveChanges();
    }
}
