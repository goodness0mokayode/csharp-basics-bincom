using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWithBincom.Controllers
{
    public class TaxCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new TaxCalculatorModel());
        }

        [HttpPost]
        public IActionResult Index(TaxCalculatorModel model)
        {
            if(ModelState.IsValid) {

                if(model.Region == "UK") {
                    model.TaxOwed = CalculateUKTax(model.Income);
                }
                if(model.Region == "Non-UK") {
                    model.TaxOwed = CalculateInternationalTax(model.Income);
                }
                return View(model);
        }
            return View(model);
    }

        private decimal CalculateUKTax(decimal income)
        {
            decimal tax = 0;


        }
        private decimal CalculateInternationalTax(decimal income)
        {
            return income * 0.25m;
        }
}