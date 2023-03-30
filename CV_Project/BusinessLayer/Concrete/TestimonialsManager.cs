using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class TestimonialsManager : ITestimonialsService
	{
		ITestimonialsDal _testimonialsDal;

        public TestimonialsManager(ITestimonialsDal testimonialsDal)
        {
            _testimonialsDal = testimonialsDal;
        }

        public void TAdd(Testimonials t)
        {
            _testimonialsDal.Insert(t);
        }

        public void TDelete(Testimonials t)
        {
            _testimonialsDal.Delete(t);
        }

        public Testimonials TGetByID(int id)
        {
            return _testimonialsDal.GetByID(id);
        }

        public List<Testimonials> TGetList()
        {
            return _testimonialsDal.GetList();
        }

        public List<Testimonials> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonials t)
        {
            _testimonialsDal.Update(t);
        }
    }
}

