using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FixMeAbac.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Home()
		{
			ViewBag.Message = "Your contact page.";

			IFirebaseConfig config = new FirebaseConfig
			{
				AuthSecret = "AIzaSyD9wBjZlpm2qOyUlnzh4Ax_8a22p2kTayo",
				BasePath = "https://fixmeabac.firebaseio.com/"
			};

			return View();
		}

		public ActionResult Detail()
		{
			return View();
		}

	}
}