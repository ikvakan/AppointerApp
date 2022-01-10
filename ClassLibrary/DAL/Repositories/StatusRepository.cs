
using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        public StatusRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }



    }
}
