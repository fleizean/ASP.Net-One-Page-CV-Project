using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        SenderReceiverMessageManager senderReceiverMessageManager = new SenderReceiverMessageManager(new EfSenderReceiverMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public AdminMessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult ReceiverMessageList()
        {
            string p;
            p = "admin@fleizean.com";
            var values = senderReceiverMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            string p;
            p = "admin@fleizean.com";
            var values = senderReceiverMessageManager.GetListSenderMessage(p);
            return View(values);
        }

        [HttpGet]
        public IActionResult ReceiverMessageListDetails(string sender, string receiver)
        {

            string p;
            p = "admin@fleizean.com";
            var values = senderReceiverMessageManager.GetListReceiverMessage(p);
            return View(values);
        }
        [HttpPost]
        public IActionResult ReceiverMessageListDetails(SenderReceiverMessage p)
        {
            string email;
            email = "admin@fleizean.com";
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = email;
            p.SenderName = "Admin";
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            senderReceiverMessageManager.TAdd(p);
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpGet]
        public IActionResult SenderMessageListDetails(string sender, string receiver)
        {
            string p;
            p = "admin@fleizean.com";
            var values = senderReceiverMessageManager.GetListSenderMessage(p);
            return View(values);
        }
        [HttpPost]
        public IActionResult SenderMessageListDetails(SenderReceiverMessage p)
        {
            string email;
            email = "admin@fleizean.com";
            string mail = email;
            string name = "Admin";
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            senderReceiverMessageManager.TAdd(p);
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpGet]
        public IActionResult SendAdminMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendAdminMessage(SenderReceiverMessage p)
        {
            string email;
            email = "admin@fleizean.com";
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = email;
            p.SenderName = "Admin";
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            senderReceiverMessageManager.TAdd(p);

            return RedirectToAction("Index", "Dashboard");

        }
    }
}

