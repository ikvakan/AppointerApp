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
    public class HomeController : Controller
    {
        private readonly UniteOfWork uow;

        public HomeController()
        {
            uow = new UniteOfWork(new ModelContainer());
        }

        public ActionResult Index()
        {

            return View();
        }



        public ActionResult Reservation()
        {
            SetCategories();
            return View();
        }

        [HttpPost]

        public ActionResult Reservation(int IdCategory)
        {

            SetCategories();

            var idCategory = IdCategory;

            var companies = uow.Company.GetCompaniesByCategory(idCategory).ToList();

            return View("Reservation", companies);
        }

        public ActionResult CompanyOverview(int idCompany)
        {
            ResetServiceSession();
            var company = uow.Company.GetById(idCompany);
            var workingHours = uow.WorkingHours.GetWorking_HoursForCompany(company.IdCompany).ToList();

            ViewBag.categoryName = company.Category.CategoryName;
            ViewBag.workingHours = (List<Working_Hours>)workingHours;
            ViewBag.workers = uow.Workers.GetWorkersForCompany(company.IdCompany).ToList();

            Session["selectedIdCompany"] = idCompany;

            return View(company);
        }


        [HttpGet]
        public ActionResult ChooseService()
        {
            if (Session["userLogin"] == null && Session["partnerLogin"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            else if (Session["selectedIdCompany"] == null)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Neovlašten pristup." });
            }

            var idCompany = (int)Session["selectedIdCompany"];

            var serviceTypes = uow.ServiceTypes.GetServiceTypeForCompany(idCompany).ToList();

            if (serviceTypes == null || serviceTypes.Count() == 0)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Upozorenje: Tvrtka nema usluge." });
            }


            if (Session["selectedIdServiceType"] == null)
            {
                ViewBag.service = null;

                ViewBag.serviceTypes = SetServiceTypes(idCompany);
            }
            else
            {
                var idServiceType = (int)Session["selectedIdServiceType"];
                List<SelectListItem> selectListItems = new List<SelectListItem>();
                foreach (var item in serviceTypes)
                {
                    SelectListItem selectListItem = new SelectListItem()
                    {
                        Text = item.Name,
                        Value = item.IdServiceType.ToString(),
                        Selected = (item.IdServiceType == idServiceType) ? true : false
                    };
                    selectListItems.Add(selectListItem);
                }

                ViewBag.serviceTypes = (List<SelectListItem>)selectListItems;

                var services = uow.Services.GetServiceByServiceType(idServiceType);
                ViewBag.services = (List<Service>)services;

            }


            return View();
        }



        [HttpPost]
        public ActionResult ChooseService(int IdServiceType)
        {

            if (Session["selectedIdCompany"] == null)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Neovlašten pristup." }); ;
            }



            var idCompany = (int)Session["selectedIdCompany"];

            var serviceTypes = uow.ServiceTypes.GetServiceTypeForCompany(idCompany).ToList();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (var item in serviceTypes)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.IdServiceType.ToString(),
                    Selected = item.IdServiceType == IdServiceType
                };
                selectListItems.Add(selectListItem);
            }

            ViewBag.serviceTypes = (List<SelectListItem>)selectListItems;


            var servicesForServiceType = uow.Services.GetServiceByServiceType(IdServiceType).ToList();
            ViewBag.servicesForServiceType = (List<Service>)servicesForServiceType;


            return View();
        }


        public ActionResult ServiceSession(int idService, int IdServiceType)
        {


            ServicesSessionModel sessionModel;
            if (Session["serviceSession"] == null)
            {
                sessionModel = new ServicesSessionModel();
                var service = uow.Services.GetById(idService);
                sessionModel.Services.Add(service);
                Session["serviceSession"] = sessionModel;


            }
            else
            {
                sessionModel = (ServicesSessionModel)Session["serviceSession"];
                var service = uow.Services.GetById(idService);
                sessionModel.Services.Add(service);


            }


            Session["selectedIdServiceType"] = IdServiceType;

            return RedirectToAction("ChooseService", "Home");



        }

        public ActionResult DeleteService(int idService)
        {

            var sessionModel = (ServicesSessionModel)Session["serviceSession"];

            var service = sessionModel.Services.FirstOrDefault(s => s.IdService == idService);

            sessionModel.Services.Remove(service);

            Session["serviceSession"] = sessionModel;


            return RedirectToAction("ChooseService", "Home");
        }

        private void SetCategories()
        {
            List<Category> categoryList = uow.Category.GetAll().ToList();
            List<SelectListItem> selectCategories = new List<SelectListItem>();

            foreach (var item in categoryList)
            {
                selectCategories.Add(new SelectListItem { Value = item.IdCategory.ToString(), Text = item.CategoryName });
            }

            ViewBag.Categories = selectCategories;
        }


        private List<SelectListItem> SetServiceTypes(int idCompany)
        {

            var serviceTypes = uow.ServiceTypes.GetServiceTypeForCompany(idCompany).ToList();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (var item in serviceTypes)
            {
                SelectListItem selectListItem = new SelectListItem()
                {
                    Text = item.Name,
                    Value = item.IdServiceType.ToString()
                };
                selectListItems.Add(selectListItem);
            }

            return selectListItems;

        }

        private void ResetServiceSession()
        {
            Session["serviceSession"] = null;
            Session["selectedIdServiceType"] = null;
        }

        public JsonResult GetAppointments()
        {
            if((Session["userLogin"] != null))
            {
                var clientId = (int)Session["clientId"];

                var appointments = uow.Apponitments.GetAllAppointments().Where(x => x.Client.IdClient == clientId).Select(x => new
                {
                    id = x.IdAppointment,
                    title = x.Company.Name,
                    start = x.Date.ToString("yyyy-MM-dd")
                }).ToList();
                return new JsonResult { Data = appointments, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }

            if((Session["partnerLogin"] != null))
            {
                if(Session["companyId"] != null)
                {
                    var companyId = (int)Session["companyId"];

                    var appointments = uow.Apponitments.GetAllAppointments().Where(x => x.CompanyIdCompany == companyId).Select(x => new
                    {
                        id = x.IdAppointment,
                        title = x.Client.Name,
                        start = x.Date.ToString("yyyy-MM-dd")
                    }).ToList();
                    return new JsonResult { Data = appointments, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }
                else
                {
                    return new JsonResult { Data = View(), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
                }
            }
            return Json(new { JsonRequestBehavior.AllowGet });
        }

        [HttpPost]
        public ActionResult Appointment(AppointmentModel appointment)
        {
            
            int clientId = (int)Session["clientId"];
            int companyId = (int)Session["selectedIdCompany"];

            var allApointments = uow.Apponitments.GetAllAppointments().Where(x => x.CompanyIdCompany == companyId).ToList();

            foreach (var item in allApointments)
            {
                if (item.Date.ToString("dd.MM.yyyy") == appointment.Date.ToString("dd.MM.yyyy"))
                {
                    return Json(new { success = false }, JsonRequestBehavior.AllowGet);
                }

                if (appointment.Date.DayOfWeek == DayOfWeek.Sunday)
                {
                    return Json(new { message = "Tvrtka ne radi nedjeljom, molimo odaberite drugi datum", success = false, id = "Vikend" });
                }

                if (appointment.Date < DateTime.Now)
                {
                    return Json(new { message = "Nije moguće napraviti rezervaciju za prošlost", success = false, id = "Proslost" });
                }
            }

            

            try
            {
                var serviceSessionModel = (ServicesSessionModel)Session["serviceSession"];
                var status = uow.Status.GetAll().FirstOrDefault(s => s.Name == "Rezervacija");

                var newAppointment = new Appointment()
                {
                    
                    Date = appointment.Date,
                    Time = DateTime.Now,
                    ClientIdClient = clientId,
                    StatusIdStatus = status.IdStatus,
                    CompanyIdCompany = companyId,
                    Remark = appointment.DodatnaNapomena,
                    Duration=serviceSessionModel.GetDuration(),
                    
                   
                };


                uow.Apponitments.Insert(newAppointment);
                uow.SaveChanges();
            }
            catch (Exception ex)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Termin nije rezerviran." + ex.Message });

            }

            return Json(new { message = "Rezervacija uspješno unesena", success = true, url = Url.Action("GetAll", "Appointment") }, JsonRequestBehavior.AllowGet);
        }
    }
}