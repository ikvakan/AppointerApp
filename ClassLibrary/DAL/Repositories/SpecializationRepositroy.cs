using OICAR_Desktop.DAL.Interfaces;
using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL
{
  public  class SpecializationRepositroy : Repository<Specialization>, ISpecializationRepository
    {
        public SpecializationRepositroy(ModelContainer modelContainer) : base(modelContainer)
        {
        }



    }
}
