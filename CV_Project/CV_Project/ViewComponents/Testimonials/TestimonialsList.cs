using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project.ViewComponents.Testimonials
{
	public class TestimonialsList : ViewComponent
	{
		TestimonialsManager testimonialsManager = new TestimonialsManager(new EfTestimonialsDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }
    }
}

