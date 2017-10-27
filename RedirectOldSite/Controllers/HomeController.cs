using System.Web.Mvc;

namespace RedirectOldSite.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return Redirect("http://bittencourt.somee.com");
		}

		public ActionResult AboutMe()
		{
			return Redirect("http://bittencourt.somee.com/Home/AboutMe");
		}
	}
}