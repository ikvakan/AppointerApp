    
using ClassLibrary.DAL;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {

        private readonly UniteOfWork uow;
        public AccountController()
        {
            uow = new UniteOfWork(new ModelContainer());
        }
        
        // GET: Account

        public ActionResult Login()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {

                var companyLogin = uow.CompanyLogin.GetCompanyLogin(loginModel.UserName,loginModel.Password);
                var clientLogin = uow.ClientLogin.GetClientLogin(loginModel.UserName, loginModel.Password);

                if (companyLogin != null)
                {
                    var company = uow.Company.GetCompanyForUser(companyLogin.IdCompanyLogin);

                    Session["partnerLogin"] = companyLogin;
                    Session["userName"] = companyLogin.UserName;
                    if (company != null )
                    {
                        Session["companyId"] = company.IdCompany;
                    }
                    ViewBag.checkLogin = false;
                    return RedirectToAction("Index","Home");
                }

                else if (clientLogin !=null)
                {
                    var client = uow.Clients.GetClientByClientLoginId(clientLogin.IdClientLogin);

                    Session["userLogin"] = client;
                    Session["userName"] = clientLogin.UserName;
                    Session["clientId"] = client.IdClient;
                    
                 
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(String.Empty, "Korisničko ime ili lozinka nisu ispravno unešeni");
                    
                }
            }

            return View();
        }

        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(ClientModel clientModel)
        {
            if (!clientModel.AcceptTearmsAndConditions)
            {
                ModelState.AddModelError(nameof(clientModel.AcceptTearmsAndConditions), "Morate prihvatiti uvjete.");
                return View(clientModel);
            }


            if (ModelState.IsValid)
            {
                try
                {

                    if (Request.Cookies["popupConsent"] != null)
                    {
                        var clientGdpr = GetClientGDPR();
                        uow.ClientGDPR.Insert(clientGdpr);
                    }

                    var client = new Client
                    {
                        Name = clientModel.Name,
                        Surname = clientModel.Surname,
                        Email = clientModel.Email,
                        Contact = clientModel.Contact,
                        Adress = clientModel.Adress,
                        OIB = clientModel.OIB,
                        City = clientModel.City,
                    };

                    var clientLogin = new ClientLogin
                    {
                        UserName = clientModel.UserName,
                        Password = clientModel.Password
                    };



                    uow.Clients.Insert(client);
                    uow.ClientLogin.Insert(clientLogin);

                    uow.SaveChanges();

                    return RedirectToAction("Index", "Home");

                }
                catch (Exception ex)
                {

                    return RedirectToAction("CustomeError", "Error", new { message = "Greška: Korisnik nije registriran." }); 
                }
            }

            return View(clientModel);

        }

        private ClientGDPR GetClientGDPR()
        {
            ClientGDPR clientGDPR = new ClientGDPR();
            var autorisePersonalInformationCookie = Request.Cookies["autorisePersonalInformation"].Value.ToString();
            var targetedAdvertisingCookie = Request.Cookies["targetedAdvertising"].Value.ToString();
            var cookieConsentCookie = Request.Cookies["cookieConsent"].Value.ToString();

            clientGDPR.AuthorizePersonalInformation = autorisePersonalInformationCookie.Equals("true") ? true : false; 
            clientGDPR.TargetedAdvertisement= targetedAdvertisingCookie.Equals("true") ? true : false; 
            clientGDPR.AccessDeviceData = cookieConsentCookie.Equals("true") ? true : false; 
            

            return clientGDPR;
        }


        public ActionResult RegisterFirm()
        {

            if (Session["partnerLogin"] == null)
            {
                return RedirectToAction("Login");
            }

            SetCategories();

            return View();
        }

        [HttpPost]

        public ActionResult RegisterFirm(CompanyModel companyModel)
        {

            if (ModelState.IsValid)
            {
                try
                {
                   SetCategories();
                    var companyLogin = Session["partnerLogin"] as CompanyLogin;

                    Company company = new Company
                    {
                        Name = companyModel.Name,
                        Adress = companyModel.Adress,
                        City = companyModel.City,
                        Email = companyModel.Email,
                        Contact = companyModel.Contact,
                        CategoryIdCategory = companyModel.IdCategory,
                        Description = String.IsNullOrEmpty(companyModel.Description) ? "":companyModel.Description,
                        CompanyLoginIdCompanyLogin = companyLogin.IdCompanyLogin,
                        PicPath = String.Empty
                    };

                    uow.Company.Insert(company);
                    uow.SaveChanges();

                    return RedirectToAction("Index", "Home");
                    
                }
                catch (Exception ex)
                {

                    return RedirectToAction("CustomeError", "Error", new { message = "Greška: Tvrtka nije registrirana." + ex.Message });
                }
            }
            else
            {
                return View(companyModel);
            }


        }

        public ActionResult RegisterPartner()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterPartner(RegisterPartnerModel registerPartnerModel)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    CompanyLogin companyLogin = new CompanyLogin
                    {
                        Name = registerPartnerModel.Name,
                        Surname = registerPartnerModel.Surname,
                        UserName=registerPartnerModel.UserName,
                        Email = registerPartnerModel.Email,
                        Contact = registerPartnerModel.Contact,
                        Password = registerPartnerModel.Password
                    };

                    if (uow.CompanyLogin.CheckCompanyUserName(companyLogin.UserName))
                    {

                        return RedirectToAction("CustomeError", "Error", new { message = "Greška: Korisnik već postoji."  });

                    }

                    uow.CompanyLogin.Insert(companyLogin);
                    uow.SaveChanges();
                }
                catch (Exception ex)
                {

                    return RedirectToAction("CustomeError","Error",new {message="Greška: Korisnik nije dodan." });
                }
            }
            else
            {
                return View(registerPartnerModel);
            }

            return RedirectToAction("PartnerConfirmed", "Confirmation");
            
        }

        public ActionResult LogOut()
        {
            if (Session["partnerLogin"] == null && Session["userLogin"] == null)
            {
                return RedirectToAction("Index","Home");
            }
            
           
            else
            {
                if (Session["partnerLogin"] != null)
                {

                    
                    var partnerLogin = (CompanyLogin)Session["partnerLogin"];
                    var message = partnerLogin.UserName;
                    ViewBag.LogOutMessage = message;
                    FormsAuthentication.SignOut();
                    Session.Abandon();
                    return View();
                    
                }
                else if(Session["userLogin"] != null)
                {

                    var userName= Session["userName"];
                    var message = userName;
                    ViewBag.LogOutMessage = message;
                    FormsAuthentication.SignOut();
                    Session.Abandon();
                    return View();
                    
                }
            }
            return View();
        }

        private void SetCategories()
        {
            List<Category> categoryList = uow.Category.GetAll().ToList();

            List<SelectListItem> selectCategories = new List<SelectListItem>();

            foreach (var item in categoryList)
            {
                selectCategories.Add(new SelectListItem { Value = item.IdCategory.ToString(), Text = item.CategoryName });
            }

            ViewBag.Categories = (List<SelectListItem>)selectCategories;
        }
    }
}