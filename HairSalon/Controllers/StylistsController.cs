using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;

namespace HairSalon.Controllers
{
  public class StylistsController : Controllers
  {
    [HttpGet]
    public ActionResult Index()
    {
      return View();
    }
  }
}
