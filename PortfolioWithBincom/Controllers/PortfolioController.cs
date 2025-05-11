using Microsoft.AspNetCore.Mvc; 

namespace PortfolioWithBincom.Controllers
{
    public class PortfolioController : Controller

    {
        public IActionResult Index ()
        {
            return View();
        }

    }

}