﻿using System.Web.Mvc;

namespace FunctionalDecomposition.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return this.View();
    }
  }
}
