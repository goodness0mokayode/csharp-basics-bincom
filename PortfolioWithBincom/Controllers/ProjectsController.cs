using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWithBincom.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}