using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace CV_Project.Areas.Writer.Models
{
	public class UserEditViewModel
	{
		public string Name { get; set; }
        public string Surname { get; set; }
        [NotMapped]
        public string Password { get; set; }
        [NotMapped]
        public string PasswordConfirm { get; set; }
        public string PictureUrl { get; set; }
        public IFormFile Picture { get; set; }
    }
}

