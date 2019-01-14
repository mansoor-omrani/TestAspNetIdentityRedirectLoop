using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAspNetIdentityRedirectLoop.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class MainController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}