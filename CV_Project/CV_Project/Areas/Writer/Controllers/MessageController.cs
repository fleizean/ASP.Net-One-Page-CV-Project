using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        SenderReceiverMessageManager senderReceiverMessageManager = new SenderReceiverMessageManager(new EfSenderReceiverMessageDal());

        private readonly UserManager<WriterUser> _userManager;

        public MessageController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = senderReceiverMessageManager.GetListReceiverMessage(p);
            return View(messageList);
        }
        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = senderReceiverMessageManager.GetListSenderMessage(p);
            return View(messageList);
        }
        [HttpGet]
        public IActionResult ReceiverMessageDetails(string sender, string receiver)
        {

            var messages = senderReceiverMessageManager.GetAll()
                .Where(m => m.Sender == sender && m.Receiver == receiver)
                .ToList();
            return View(messages);
        }
        [HttpPost]
        public async Task<IActionResult> ReceiverMessageDetails(SenderReceiverMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            senderReceiverMessageManager.TAdd(p);
            return RedirectToAction("Dashboard", "Writer");
        }
        [HttpGet]
        public IActionResult SenderMessageDetails(string sender, string receiver)
        {
            var messages = senderReceiverMessageManager.GetAll()
                .Where(m => m.Sender == sender && m.Receiver == receiver)
                .ToList();
            return View(messages);
        }
        [HttpPost]
        public async Task<IActionResult> SenderMessageDetails(SenderReceiverMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            senderReceiverMessageManager.TAdd(p);
            return RedirectToAction("Dashboard", "Writer");
        }
        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SenderReceiverMessage p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = values.Email;
            string name = values.Name + " " + values.Surname;
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            p.SenderName = name;
            Context c = new Context();
            var usernamesurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            p.ReceiverName = usernamesurname;
            senderReceiverMessageManager.TAdd(p);

            return RedirectToAction("Dashboard", "Writer");

        }
    }
}

