using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FooterController : Controller
    {
        FooterManager footerManager = new FooterManager(new EfFooterDal());

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            var values = footerManager.TGetByID(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Footer footer)
        {
            footerManager.TUpdate(footer);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}

