using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            if (Program.IsConnectedToInternet())
            {
                // Weather API
                string api = "cdb20bebdbea4054853131830232603";
                string location = "izmit";

                // Web isteği yaparak XML veriyi alın
                string url = $"http://api.weatherapi.com/v1/current.xml?key={api}&q={location}";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(url);

                // XML veriden temp_c alanını okuyun
                ViewBag.v5 = xmlDoc.SelectSingleNode("//temp_c")?.InnerText;
            }


            // Statistics
            Context c = new Context();
            ViewBag.v1 = c.SenderReceiverMessages.Where(x => x.Receiver == values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();
            
            return View();
        }
    }
}

// http://api.weatherapi.com/v1/current.xml?key=cdb20bebdbea4054853131830232603&q=izmit