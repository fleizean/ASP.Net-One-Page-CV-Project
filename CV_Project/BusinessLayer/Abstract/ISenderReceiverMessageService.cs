using System;
using System.Collections.Generic;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ISenderReceiverMessageService : IGenericService<SenderReceiverMessage>
    {
        List<SenderReceiverMessage> GetListSenderMessage(string p);
        List<SenderReceiverMessage> GetListReceiverMessage(string p);
    }
}

