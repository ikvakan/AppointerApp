using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Repositories
{
    public class CompanyLoginRepository : Repository<CompanyLogin>, ICompanyLoginRepository
    {
        

        public CompanyLoginRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

        public bool CheckCompanyUserName(string userName)
        {
            return db.CompanyLogin.Any(cl => cl.UserName == userName);
        }
        public bool CheckCompanyLoginCredentials(string userName,string passwoord)
        {
            return db.CompanyLogin.Any(cl => cl.UserName == userName && cl.Password==passwoord);
        }



        public CompanyLogin GetCompanyLogin(string userName,string password)
        {
            return db.CompanyLogin.FirstOrDefault(cl => cl.UserName == userName && cl.Password == password);
        }

        public CompanyLogin GetCompanyLoginByIdCompany(int idCompanyLogin)
        {
            return db.CompanyLogin.FirstOrDefault(c => c.IdCompanyLogin == idCompanyLogin);
        }
    }
}
