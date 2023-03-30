using System;
using System.ComponentModel.DataAnnotations;

namespace CV_Project_Api.DAL.Entity
{
	public class Category
	{
		[Key]
		public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}

