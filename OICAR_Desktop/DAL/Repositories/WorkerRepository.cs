using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL.Interfaces
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }
    }
}
