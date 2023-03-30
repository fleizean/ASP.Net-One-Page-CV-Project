using System;
using System.Linq;
using BusinessLayer.Concrete;
using CV_Project.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace CV_Project.ViewComponents.Dashboard
{
	public class AdminNavbarMessageList : ViewComponent
    {
		SenderReceiverMessageManager senderReceiverMessageManager = new SenderReceiverMessageManager(new EfSenderReceiverMessageDal());
		public IViewComponentResult Invoke()
		{
            Context context = new Context();
            var filter = "admin@fleizean.com";
            var list = (from x in context.Users
                        join y in context.SenderReceiverMessages
                        on x.Email equals y.Sender
                        where y.Receiver == filter
                        select new WriterMessageImageUrl
                        {
                            ImageUrl = x.ImageUrl,
                            Date = y.Date,
                            SenderName = y.SenderName,
                            MessageContent = y.MessageContent,
                            Id = y.ID
                        }).OrderByDescending(x => x.Id).Take(3).ToList();
            return View(list);
        }
	}
}

