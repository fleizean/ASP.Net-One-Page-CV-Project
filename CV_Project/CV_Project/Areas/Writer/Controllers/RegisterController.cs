using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using CV_Project.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;
using System.IO;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Areas.Writer.Controllers
{
    [AllowAnonymous]
    [Area("Writer")]
    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel p)
        {
            var resource = Directory.GetCurrentDirectory();
            var extension = Path.GetExtension(p.Picture.FileName);
            var imagename = Guid.NewGuid() + extension;
            var savelocation = resource + "/wwwroot/userimage/" + imagename;
            var stream = new FileStream(savelocation, FileMode.Create);
            await p.Picture.CopyToAsync(stream);
            p.ImageUrl = imagename;
            WriterUser w = new WriterUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
                ImageUrl = imagename,
            };

            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(w, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Writer");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(p);
        }
    }
}

