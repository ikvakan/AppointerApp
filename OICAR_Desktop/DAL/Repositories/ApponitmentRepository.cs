using OICAR_Desktop.DAL.Interfaces;
using OICAR_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OICAR_Desktop.DAL
{
    public class ApponitmentRepository : Repository<Appointment>, IApponitmentRepository
    {
        public ApponitmentRepository(ModelContainer modelContainer) : base(modelContainer)
        {
        }

        public IEnumerable<Appointment> GetAppointmentsByDate(DateTime date)
        {
            return db.Appointment.Where(a => a.Date == date);
        }

        public IEnumerable<Appointment> GetAppointmentsByService(List<Service> services)
        {



            List<Appointment> appointments = new List<Appointment>();
            foreach (Service item in services)
            {

                List<Appointment> result = db.Appointment.Where(a => a.ServiceIdService == item.IdService).ToList();
                if (result != null)
                {
                    foreach (var appointment in result)
                    {
                        appointments.Add(appointment);

                    }

                }
            }

            return appointments;
        }

        public IEnumerable<Appointment> GetAppointmentsByStatus(string status)
        {
            return db.Appointment.Where(a => a.Status.Name == status);
        }


    }
}
