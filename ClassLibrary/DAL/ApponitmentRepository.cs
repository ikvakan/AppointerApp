using OICAR_Desktop.DAL.Interfaces;
using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OICAR_Desktop.DAL
{
    public class ApponitmentRepository : Repository<Appointment>, IApponitmentRepository
    {
        public ApponitmentRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

    

        public ModelContainer ModelContainer { get { return db as ModelContainer; } }
    }
}
