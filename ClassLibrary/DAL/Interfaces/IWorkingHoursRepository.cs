using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
   public interface IWorkingHoursRepository :IRepository<Working_Hours>
    {

        IEnumerable<Working_Hours> GetWorking_HoursForCompany(int idCompany);
        Working_Hours GetWorkingHoursByDayForCompany(string day,int idCompany);

        int GetWorkingHoursIdByDayForCompany(string day, int idCompany);
    }
}
