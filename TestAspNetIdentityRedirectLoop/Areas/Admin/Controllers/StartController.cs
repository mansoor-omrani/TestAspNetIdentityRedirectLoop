using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestAspNetIdentityRedirectLoop.Areas.Admin.Controllers
{
    [Authorize]
    public class StartController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}