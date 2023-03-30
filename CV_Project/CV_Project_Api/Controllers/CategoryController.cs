using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CV_Project_Api.DAL.ApiContext;
using CV_Project_Api.DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace CV_Project_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		[HttpGet]
		public IActionResult CategoryList()
		{
			using var c = new Context();
			return Ok(c.Categories.ToList()); /* Ok ibaresi HTTP isteğine karşı başarılı bir yanıt vermek için kullanılan bir ASP.NET Core Action Result'u döndürür.
						  * Bu, 200 HTTP durum kodu ile birlikte boş bir yanıttır. 
						  * Ok() metodu genellikle başarılı bir GET isteği için kullanılır.*/
		}
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			using var c = new Context();
			var value = c.Categories.Find(id);
			if (value == null)
				return NotFound();
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CategoryAdd(Category p)
		{
			using var c = new Context();
			c.Add(p);
			c.SaveChanges();
			return Created("", p);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var c = new Context();
            var value = c.Categories.Find(id);
            if (value == null)
                return NotFound();
			c.Remove(value);
			c.SaveChanges();
			return NoContent();
        }
		[HttpPut]
        public IActionResult CategoryUpdate(Category p)
		{
            using var c = new Context();
			var value = c.Find<Category>(p.CategoryID);
			if (value == null)
				return NotFound();
			value.CategoryName = p.CategoryName;
			c.Update(value);
			c.SaveChanges();
			return NoContent();
        }
    }
}

