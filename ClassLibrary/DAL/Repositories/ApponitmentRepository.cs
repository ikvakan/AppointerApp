

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClassLibrary.DAL.Interfaces;
using ClassLibrary.Model;

namespace ClassLibrary.DAL
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


        public IEnumerable<Appointment> GetAppointmentsByStatusForCompany(string status,int companyLoginId)
        {
            return db.Appointment.Where(a => a.Status.Name == status && a.Company.CompanyLoginIdCompanyLogin==companyLoginId);
        }



        public List<Appointment> GetAllAppointments()
        {
            return db.Appointment.ToList();
        }
    }
}
