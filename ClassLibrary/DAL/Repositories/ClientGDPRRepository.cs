using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Repositories
{
    public class ClientGDPRRepository : Repository<ClientGDPR>, IClientGDPRRepository
    {
        public ClientGDPRRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }
    }
}
