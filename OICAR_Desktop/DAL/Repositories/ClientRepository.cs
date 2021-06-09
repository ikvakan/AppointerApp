using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {

      

        public ClientRepository(ModelContainer modelContainer) : base(modelContainer)
        {
            
        }

        
       

    }
}
