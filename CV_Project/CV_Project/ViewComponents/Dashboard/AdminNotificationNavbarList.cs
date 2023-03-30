using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.ViewComponents.Dashboard
{
	public class AdminNotificationNavbarList : ViewComponent
    {
        ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());
        public IViewComponentResult Invoke()
        {
            var value = toDoListManager.TGetByID(1);
            ViewBag.v1 = value.Content;
            return View();
        }
    }
}

