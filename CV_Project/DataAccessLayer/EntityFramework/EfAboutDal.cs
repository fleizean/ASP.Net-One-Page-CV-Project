using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
	public class EfAboutDal : GenericRepository<About>, IAboutDal // ,'den sonraki kısım eğer biz ileride sadece About sayfası için çalışacak bir işlem yapmak istersek Abstracta takılmamak için
	{
		
	}
}

