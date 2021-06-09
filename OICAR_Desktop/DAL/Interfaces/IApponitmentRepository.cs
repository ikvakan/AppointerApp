using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OICAR_Desktop.DAL.Interfaces
{
   public interface IApponitmentRepository :IRepository<Appointment>
    {

        IEnumerable<Appointment> GetAppointmentsByStatus(string status);
        IEnumerable<Appointment> GetAppointmentsByDate(DateTime date);
        IEnumerable<Appointment> GetAppointmentsByService(List<Service> services);

        
    }
}
