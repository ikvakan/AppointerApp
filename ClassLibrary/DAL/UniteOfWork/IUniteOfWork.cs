using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
    public interface IUniteOfWork : IDisposable
    {
        IClientRepository Clients { get; }
        IServiceRepository Services { get; }
        IWorkerRepository  Workers { get; }
       
        IServiceTypeRepository ServiceTypes { get; }

        IApponitmentRepository Apponitments { get; }

        IStatusRepository Status { get; }

        ICompanyRepository Company { get; }

        IWorkingHoursRepository WorkingHours { get; }
        ICategoryRepository Category { get; }

        ICompanyLoginRepository CompanyLogin { get; }

        IClientLoginRepository ClientLogin { get; }

        IClientGDPRRepository ClientGDPR { get; }

        int SaveChanges();
    }
}
