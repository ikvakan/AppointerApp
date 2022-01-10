using OICAR_Desktop.DAL.Interfaces;
using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL
{
    public class WorkerSpecializationsRepository : Repository<Worker_Specializations>, IWorkerSpecializationRepository
    {
    
        public WorkerSpecializationsRepository(ModelContainer modelContainer) : base(modelContainer)
        {

        }

        
    }
}
