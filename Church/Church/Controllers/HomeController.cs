using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Church.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.Message = "Soldiers Of The Cross";

			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "This application will allow each mission to add users and have a better view of their member base.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Contact us.";

			return View();
		}
	}
}
