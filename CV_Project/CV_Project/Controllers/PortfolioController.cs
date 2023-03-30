using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRule;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PortfolioController : Controller
	{
		PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
		// GET: /<controller>/
		public IActionResult Index()
		{
			var values = portfolioManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddPortfolio()
		{
            return View();
		}
		[HttpPost]
		public IActionResult AddPortfolio(Portfolio portfolio)
		{
            PortfolioValidator validations = new PortfolioValidator();
			ValidationResult result = validations.Validate(portfolio);

			if (result.IsValid)
			{
				portfolioManager.TAdd(portfolio);
				return RedirectToAction("Index");
			}
			else
			{
				foreach(var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
		public IActionResult DeletePortfolio(int id)
		{
			var values = portfolioManager.TGetByID(id);
			portfolioManager.TDelete(values);
			return RedirectToAction("Index");
		}
        [HttpGet]
        public IActionResult EditPortfolio(int id)
        {
            var values = portfolioManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPortfolio(Portfolio portfolio)
        {
            PortfolioValidator validations = new PortfolioValidator();
            ValidationResult result = validations.Validate(portfolio);
            
			if (result.IsValid)
			{
                portfolioManager.TUpdate(portfolio);
                return RedirectToAction("Index");
            }
			else
			{
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
			return View();   
        }
    }
}

