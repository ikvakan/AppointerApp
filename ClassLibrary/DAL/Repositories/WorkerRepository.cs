
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

        public IEnumerable<Worker> GetWorkersForCompany(int idCompany)
        {
           return db.Worker.Where(w => w.CompanyIdCompany == idCompany).ToList();
        }
    }
}
