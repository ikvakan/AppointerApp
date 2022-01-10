using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Repositories
{
    public class WorkingHoursRepository : Repository<Working_Hours>, IWorkingHoursRepository
    {
        public WorkingHoursRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

        public Working_Hours GetWorkingHoursByDayForCompany(string day,int idCompany)
        {
            return db.Working_Hours.FirstOrDefault(wh=>wh.Day==day && wh.CompanyIdCompany==idCompany);
        }

        public int GetWorkingHoursIdByDayForCompany(string day,int idCompany)
        {
            return db.Working_Hours.Where(w=>w.Day==day && w.CompanyIdCompany==idCompany).Select(wh=>wh.IdWorkingHours).FirstOrDefault(); 
        }



        public IEnumerable<Working_Hours> GetWorking_HoursForCompany(int idCompany)
        {
            return db.Working_Hours.Where(wh=>wh.CompanyIdCompany==idCompany).ToList();
        }

        
    }
}
