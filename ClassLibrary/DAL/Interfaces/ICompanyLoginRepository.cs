using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
    public interface ICompanyLoginRepository : IRepository<CompanyLogin>
    {
        bool CheckCompanyUserName(string userName);
        bool CheckCompanyLoginCredentials(string userName, string passwoord);
        CompanyLogin GetCompanyLogin(string userName,string password);

        CompanyLogin GetCompanyLoginByIdCompany(int idCompany);

    }
}
