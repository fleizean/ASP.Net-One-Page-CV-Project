using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class FooterManager : IFooterService
    {
        IFooterDal _footerDal;

        public FooterManager(IFooterDal footerDal)
        {
            _footerDal = footerDal;
        }

        public void TAdd(Footer t)
        {
            _footerDal.Insert(t);
        }

        public void TDelete(Footer t)
        {
            _footerDal.Delete(t);
        }

        public Footer TGetByID(int id)
        {
            return _footerDal.GetByID(id);
        }

        public List<Footer> TGetList()
        {
            return _footerDal.GetList();
        }

        public List<Footer> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Footer t)
        {
            _footerDal.Update(t);
        }
    }
}

