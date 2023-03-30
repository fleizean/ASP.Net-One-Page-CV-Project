using System;
using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class SenderReceiverMessageManager : ISenderReceiverMessageService
    {
        ISenderReceiverMessageDal _senderReceiverMessageDal;

        public SenderReceiverMessageManager(ISenderReceiverMessageDal senderReceiverMessageDal)
        {
            _senderReceiverMessageDal = senderReceiverMessageDal;
        }

        public List<SenderReceiverMessage> GetListReceiverMessage(string p)
        {
            return _senderReceiverMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<SenderReceiverMessage> GetListSenderMessage(string p)
        {
            return _senderReceiverMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TAdd(SenderReceiverMessage t)
        {
            _senderReceiverMessageDal.Insert(t);
        }

        public void TDelete(SenderReceiverMessage t)
        {
            _senderReceiverMessageDal.Delete(t);
        }
        public List<SenderReceiverMessage> GetAll()
        {
            return _senderReceiverMessageDal.GetList();
        }

        public SenderReceiverMessage TGetByID(int id)
        {
            return _senderReceiverMessageDal.GetByID(id);
        }

        public List<SenderReceiverMessage> TGetList()
        {
            return _senderReceiverMessageDal.GetList();
        }

        public List<SenderReceiverMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SenderReceiverMessage t)
        {
            throw new NotImplementedException();
        }
    }
}

