using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Repositories
{
    public class ClientLoginRepository : Repository<ClientLogin>, IClientLoginRepository
    {
        public ClientLoginRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

        public ClientLogin GetClientLogin(string userName, string password)
        {
            return db.ClientLogin.FirstOrDefault(c => c.UserName == userName && c.Password == password);
        }
    }
}
