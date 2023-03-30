using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CV_Project.Areas.Writer.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CV_Project.Areas.Writer.Controllers
{
	[Area("Writer")]
    // [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
	{
		private readonly UserManager<WriterUser> _userManager;

		public ProfileController(UserManager<WriterUser> userManager)
		{
			_userManager = userManager;
		}
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			var values = await _userManager.FindByNameAsync(User.Identity.Name);
			UserEditViewModel model = new UserEditViewModel();
			model.Name = values.Name;
			model.Surname = values.Surname;
			model.PictureUrl = values.ImageUrl;
			return View(model);
		}
		[HttpPost]
		public async Task<IActionResult> Index(UserEditViewModel p)
		{
			var user = await _userManager.FindByNameAsync(User.Identity.Name);
			if (p.Picture != null)
			{
				var resource = Directory.GetCurrentDirectory();
				var extension = Path.GetExtension(p.Picture.FileName);
				var imagename = Guid.NewGuid() + extension;
				var savelocation = resource + "/wwwroot/userimage/" + imagename;
				var stream = new FileStream(savelocation, FileMode.Create);
				await p.Picture.CopyToAsync(stream);
				user.Name = p.Name;
				user.Surname = p.Surname;
				user.ImageUrl = imagename;
				if (!string.IsNullOrEmpty(p.Password) && p.Password == p.PasswordConfirm)
				{
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                    if (TryValidateModel(user))
					{
						var resultone = await _userManager.UpdateAsync(user);
						if (resultone.Succeeded)
						{
                            return RedirectToAction("Profile", "Writer");
                        }
					}
				}
                var resulttwo = await _userManager.UpdateAsync(user);
                if (resulttwo.Succeeded)
                {
                    return RedirectToAction("Profile","Writer");
                }
            }
			else
			{
				user.Name = p.Name;
				user.Surname = p.Surname;
				if (!string.IsNullOrEmpty(p.Password) && p.Password == p.PasswordConfirm)
				{
					user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
				}
				// TryValidateModel() ile modelin geçerliliğini kontrol ediyoruz.
				if (TryValidateModel(user))
				{
					var result = await _userManager.UpdateAsync(user);
					if (result.Succeeded)
					{
                        return RedirectToAction("Profile", "Writer");
                    }
				}
			}
			return View();
		}
	}
}

