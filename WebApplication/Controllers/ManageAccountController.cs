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
    public class ManageAccountController : Controller
    {
        // GET: ManageAccount

        private UniteOfWork uow;
        public ManageAccountController()
        {
            uow = new UniteOfWork(new ModelContainer());
        }
        public ActionResult GetAccountData()
        {
            
            if (Session["userLogin"] == null || Session["clientId"]==null)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Niste prijavljen korisnik." });
            }

            var clientId = (int)Session["clientId"];
            var user=uow.Clients.GetClientByClientLoginId(clientId);

            if (user == null)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Nemate pristup." });
            }

            UserAccountModel userAccountModel = new UserAccountModel
            {
                IdClientGDPR = user.ClientGDPR.IdClientGDPR,
                AuthorizePersonlaInformation = user.ClientGDPR.AuthorizePersonalInformation,
                AccessDeviceData = user.ClientGDPR.AccessDeviceData,
                TargetedAdvertisement = user.ClientGDPR.TargetedAdvertisement,
                Client = new ClientModel
                {
                    IdClient = user.IdClient,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Contact = user.Contact,
                    Adress = user.Adress,
                    OIB = user.OIB,
                    City = user.City
                }

            };


            return View(userAccountModel);
        } 

        [HttpPost]
        public ActionResult GetAccountData(UserAccountModel userAccount)
        {
            if (userAccount == null || Session["userLogin"] == null)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Nemate pristup." });
            }

            
            try
            {

                var clientLogin= (Client)Session["userLogin"];

                ClientGDPR clientGDPR = new ClientGDPR
                {
                    IdClientGDPR = userAccount.IdClientGDPR,
                    AuthorizePersonalInformation = userAccount.AuthorizePersonlaInformation,
                    AccessDeviceData = userAccount.AccessDeviceData,
                    TargetedAdvertisement = userAccount.TargetedAdvertisement

                };

                Client client = new Client
                {
                    IdClient = userAccount.Client.IdClient,
                    Name = userAccount.Client.Name,
                    Surname = userAccount.Client.Surname,
                    Email = userAccount.Client.Email,
                    Contact = userAccount.Client.Contact,
                    Adress = userAccount.Client.Adress,
                    OIB = userAccount.Client.OIB,
                    City = userAccount.Client.City,
                    ClientLoginsIdClientLogin=clientLogin.ClientLogins.IdClientLogin,
                    ClientGDPRIdClientGDPR=clientGDPR.IdClientGDPR
                };

                uow.ClientGDPR.Update(clientGDPR);
                uow.Clients.Update(client);
                uow.SaveChanges();

                SetCookiesOnUpdate(clientGDPR);

            }
            catch (Exception ex)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Ažuriranje podataka nije uspjelo." });
            }

            return View(userAccount);
        }

        public ActionResult DeleteAccount(int clientId,int clientGDPRId)
        {
            var client = uow.Clients.GetById(clientId);
            var clientLogin = uow.ClientLogin.GetById(client.ClientLogins.IdClientLogin);
            var clientGDPR = uow.ClientGDPR.GetById(clientGDPRId);

            if (client== null)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Nemate pristup." });
            }



            try
            {
                uow.ClientGDPR.Delete(clientGDPR);
                uow.ClientLogin.Delete(clientLogin);
                uow.Clients.Delete(client);
                uow.SaveChanges();

                DeleteCookies();

                Session.Abandon();

            }
            catch (Exception)
            {
                return RedirectToAction("CustomeError", "Error", new { message = "Greška: Korisnik nije obrisan." });
            }

            return RedirectToAction("UserDeleted", "Confirmation");

        }

        private void DeleteCookies()
        {
            var autorisePersonalInformationCookie = Request.Cookies["autorisePersonalInformation"];
            var targetedAdvertisingCookie = Request.Cookies["targetedAdvertising"];
            var deviceAccessCookie = Request.Cookies["cookieConsent"];
            var popupConsentCookie = Request.Cookies["popupConsent"];


            autorisePersonalInformationCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(autorisePersonalInformationCookie);
            targetedAdvertisingCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(targetedAdvertisingCookie);
            deviceAccessCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(deviceAccessCookie);
            popupConsentCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(popupConsentCookie);
            
        }

        private void SetCookiesOnUpdate(ClientGDPR clientGDPR)
        {
            Response.Cookies["autorisePersonalInformation"].Value=clientGDPR.AuthorizePersonalInformation.Equals(true) ? "true":"false";
            Response.Cookies["targetedAdvertising"].Value= clientGDPR.TargetedAdvertisement.Equals(true) ? "true" : "false";
            Response.Cookies["cookieConsent"].Value= clientGDPR.AccessDeviceData.Equals(true) ? "true" : "false";
        }
    }
}