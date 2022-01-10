using ClassLibrary.DAL;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly UniteOfWork uow;

        public AppointmentController()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll()
        {
            var listaTermina = new List<Appointment>();

            if (Session["partnerLogin"] != null)
            {
                if (Session["companyId"] != null)
                {
                    string company = Session["companyId"].ToString();
                    int companyLoginId = Int32.Parse(company);

                    listaTermina = uow.Apponitments.GetAllAppointments().Where(x => x.CompanyIdCompany == companyLoginId).ToList();
                }
            }
            else
            {
                string client = Session["clientId"].ToString();
                int clientId = Int32.Parse(client);

                listaTermina = uow.Apponitments.GetAllAppointments().Where(x => x.ClientIdClient == clientId).ToList();
            }

            return View("Appointments", listaTermina);
        }
    }
}