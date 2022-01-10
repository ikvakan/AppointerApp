using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Repositories
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

        public IEnumerable<Company> GetCompaniesByCategory(int idCategory)
        {
            return db.Company.Where(c=>c.CategoryIdCategory==idCategory);
        }

        public Company GetCompanyForUser(int idCompanyLogin)
        {
            return db.Company.FirstOrDefault(c => c.CompanyLoginIdCompanyLogin == idCompanyLogin);
        }


    }
}
