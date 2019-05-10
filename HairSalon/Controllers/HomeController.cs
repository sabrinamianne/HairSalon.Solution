using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
  public class HomeController : Controllers
  {
    [HttpGet]
    public ActionResult Index()
    {
      return View();
    }
  }
}
