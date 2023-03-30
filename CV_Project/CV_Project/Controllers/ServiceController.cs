﻿using System;
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
    public class ServiceController : Controller
	{
		ServiceManager serviceManager = new ServiceManager(new EfServiceDal());
		// GET: /<controller>/
		public IActionResult Index()
		{
			
			var values = serviceManager.TGetList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddService()
		{
			
			return View();
		}
		[HttpPost]
		public IActionResult AddService(Service service)
		{
			serviceManager.TAdd(service);
			return RedirectToAction("Index");
		}
        public IActionResult DeleteService(int id)
        {
            var values = serviceManager.TGetByID(id);
            serviceManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditService(int id)
        {
            
            var values = serviceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditService(Service service)
        {
            serviceManager.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}

