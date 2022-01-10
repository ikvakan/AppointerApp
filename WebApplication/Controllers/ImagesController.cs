using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class ImagesController : Controller
    {
        // GET: Images
        public ActionResult RecieveImage(string imagePath)
        {

            return File($"{imagePath}","image/jpeg");
        }
    }
}