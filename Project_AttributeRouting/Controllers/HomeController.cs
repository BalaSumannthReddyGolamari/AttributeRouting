using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_AttributeRouting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("Group5/{id}")]
        public ActionResult Index()
        {
            return View();
        }
    }
}