using System;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.ViewComponents.Dashboard
{
	public class MapVisitor : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

