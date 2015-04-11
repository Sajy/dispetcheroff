/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 22.02.2015
 * Время: 13:17
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Linq;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of Shop.
	/// </summary>
	public class HomeController : Controller
	{
		
		private readonly BuyContext ds = new BuyContext();
		
		public HomeController(){
			ViewBag.Contracts=ds.Contracts.ToList();
		}
		
		public ActionResult About()
		{
			return View();
		}
		
		public ActionResult Index()
		{
			//var model = from s in ds.Contracts select s;
		
			return View(ds.Contracts.ToList());
		}
		
		[Authorize]
		public ActionResult Buy()
		{
			return View();
		}
		
	
	}
}
