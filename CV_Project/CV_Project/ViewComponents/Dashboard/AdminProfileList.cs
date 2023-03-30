using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using CV_Project.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.ViewComponents.Dashboard
{
	public class AdminProfileList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var id = HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            int userId = int.Parse(id);
            Context context = new Context();
            var loggedInUserRoleNames = (from ur in context.UserRoles
                                         join r in context.Roles on ur.RoleId equals r.Id
                                         where ur.UserId == userId
                                         select r.Name).ToList();

            var list = (from u in context.Users
                        where u.Id == userId &&
                        (loggedInUserRoleNames.Contains("Admin") || loggedInUserRoleNames.Contains("Moderator"))
                        select new
                        {
                            ImageUrl = u.ImageUrl,
                            Username = u.UserName,
                            Name = u.Name,
                            Surname = u.Surname,
                            RoleName = loggedInUserRoleNames.FirstOrDefault()
                        }).FirstOrDefault();
            ViewBag.v1 = list.ImageUrl;
            ViewBag.v2 = list.Name;
            ViewBag.v3 = list.Surname;
            return View();
        }
    }
}

