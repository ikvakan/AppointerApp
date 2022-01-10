
using ClassLibrary.DAL.Interfaces;
using ClassLibrary.DAL.Repositories;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
   public class UniteOfWork : IUniteOfWork
    {
        private readonly ModelContainer contex;

        public IClientRepository Clients { get; set; }
        public IServiceRepository Services { get; set; }
        public IWorkerRepository Workers { get; set; }

        
        public IServiceTypeRepository ServiceTypes { get; set; }

        public IApponitmentRepository Apponitments { get; set; }

        public IStatusRepository Status { get; set; }

        public ICompanyRepository Company { get; set; }

        public IWorkingHoursRepository WorkingHours { get; set; }

        public ICategoryRepository Category { get; set; }

        public ICompanyLoginRepository CompanyLogin { get; set; }

        public IClientLoginRepository ClientLogin { get; set; }

        public IClientGDPRRepository ClientGDPR { get; set; }

        public UniteOfWork(ModelContainer modelContainer)
        {
            contex = modelContainer;
            Clients = new ClientRepository(contex);
            Services = new ServiceRepository(contex);
            Workers = new WorkerRepository(contex);
            ServiceTypes = new ServiceTypeRepository(contex);
            Apponitments = new ApponitmentRepository(contex);
            Status = new StatusRepository(contex);
            Company = new CompanyRepository(contex);
            WorkingHours = new WorkingHoursRepository(contex);
            Category = new CategoryRepository(contex);
            CompanyLogin = new CompanyLoginRepository(contex);
            ClientLogin = new ClientLoginRepository(contex);
            ClientGDPR = new ClientGDPRRepository(contex);
        }

       

        public void Dispose()
        {
            contex.Dispose();
        }

        public int SaveChanges()
        {
           return contex.SaveChanges();
        }
    }
}
