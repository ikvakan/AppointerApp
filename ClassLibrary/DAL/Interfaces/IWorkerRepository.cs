
using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
   public interface IWorkerRepository : IRepository<Worker>
    {
        IEnumerable<Worker> GetWorkersForCompany(int idCompany);
        
            
        
    }
}
