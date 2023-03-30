using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.ViewComponents.Footer
{
	public class FooterList : ViewComponent
    {
        FooterManager footerManager = new FooterManager(new EfFooterDal());
        public IViewComponentResult Invoke()
        {
            var values = footerManager.TGetList();
            return View(values);
        }
    }
}

