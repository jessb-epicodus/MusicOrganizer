using Microsoft.AspNetCore.Mvc;
using ShippingCo.Models;

namespace MusicOrganizer.Controllers {
  public class HomeController : Controller {
    [HttpGet("/")]
    public ActionResult Index() {
      return View();
    }
  }
}