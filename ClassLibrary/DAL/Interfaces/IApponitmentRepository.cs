
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.DAL.Interfaces
{
   public interface IApponitmentRepository :IRepository<Appointment>
    {

        IEnumerable<Appointment> GetAppointmentsByStatusForCompany(string status,int companyLoginId);
        IEnumerable<Appointment> GetAppointmentsByDate(DateTime date);
        List<Appointment> GetAllAppointments();
    }
}
