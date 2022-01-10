
using ClassLibrary.DAL;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {

      

        public ClientRepository(ModelContainer modelContainer) : base(modelContainer)
        {
            
        }

        public Client GetClientByClientLoginId(int clientLoginId)
        {
            return db.Client.FirstOrDefault(c=>c.ClientLoginsIdClientLogin==clientLoginId);
        }


    }
}