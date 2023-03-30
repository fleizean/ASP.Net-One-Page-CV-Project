using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CV_Project.Areas.Writer.Models
{
	public class UserRegisterViewModel
	{
        [Required(ErrorMessage = "Lütfen Adınızı Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin")]
        public string ImageUrl { get; set; }
        public IFormFile Picture { get; set; }
        [Required(ErrorMessage = "Lütfen Resim Url Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]
        [Compare("Password", ErrorMessage = "Şifreler Uyumlu Değil!")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Maili Girin")]
        public string Mail { get; set; }
    }
}

