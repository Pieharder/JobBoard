using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}