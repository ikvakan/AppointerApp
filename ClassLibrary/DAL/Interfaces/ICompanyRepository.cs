using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
   public interface ICompanyRepository :IRepository<Company>
    {

        Company GetCompanyForUser(int idCompanyLogin);

        IEnumerable<Company> GetCompaniesByCategory(int idCategory);

    }
}
