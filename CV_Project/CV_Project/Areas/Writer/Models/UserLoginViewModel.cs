﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CV_Project.Areas.Writer.Models
{
	public class UserLoginViewModel
	{
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz")]
        public string Username { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Giriniz")]
        public string Password { get; set; }
    }
}

