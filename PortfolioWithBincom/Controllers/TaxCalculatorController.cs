using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWithBincom.Controllers
{
    public class TaxCalculatorController : Controller
    {
        public IActionResult Index ()
        {
            return View();
        }
    }
}