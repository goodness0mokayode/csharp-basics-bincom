using System;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioWithBincom.Controllers
{
    public class TaxCalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var taxCalc = new TaxCalculatorModel();
            return View(taxCalc);
        }

        [HttpPost]
        public IActionResult Index(TaxCalculatorModel model)
        {
            if (ModelState.IsValid)
            {
                model.TaxOwed = CalculateUKTax(model.GrossIncome);
            }
            return View(model);
        }

        private decimal CalculateUKTax(decimal income)
        {
            decimal personalAllowance = 12750;
            decimal basicRateLimit = 50270;
            decimal higherRateLimit = 125140;

            decimal basicRate = 0.2m;
            decimal higherRate = 0.4m;
            decimal additionalRate = 0.45m;

            if (income <= personalAllowance)
            {
                return 0;
            }

            decimal totalTax = 0;
            decimal taxableIncome = income - personalAllowance;

            if (income > personalAllowance)
            {
                decimal basicBandMax = basicRateLimit - personalAllowance;
                decimal basicBandIncome;

                if (taxableIncome >= basicBandMax)
                {
                    basicBandIncome = basicBandMax;
                }
                else
                {
                    basicBandIncome = taxableIncome;
                }

                decimal basicTax = basicBandIncome * basicRate;
                totalTax = totalTax + basicTax;
                taxableIncome = taxableIncome - basicBandIncome;
            }

            if (income > basicRateLimit)
            {
                decimal higherBandMax = higherRateLimit - basicRateLimit;
                decimal higherBandIncome;

                if (taxableIncome >= higherBandMax)
                {
                    higherBandIncome = higherBandMax;
                }
                else
                {
                    higherBandIncome = taxableIncome;
                }

                decimal higherTax = higherBandIncome * higherRate;
                totalTax = totalTax + higherTax;
                taxableIncome = taxableIncome - higherBandIncome;
            }

            if (income > higherRateLimit)
            {
                decimal additionalTax = taxableIncome * additionalRate;
                totalTax = totalTax + additionalTax;
            }

            return totalTax;
        }

    }
}