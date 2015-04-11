/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 22.02.2015
 * Время: 13:16
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System.Globalization;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using mvc2.Infrastructure.Concrete;
using mvc2.Infrastructure.Db;
namespace mvc2
{
	public class MvcApplication : HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			

			
			routes.MapRoute(
				"Default",
				"{controller}/{action}/{id}",
				new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}

		public void Application_Start()
		{
			// Initializes and seeds the database.
			//Database.SetInitializer(new DbInitializer());
			
			// Forces initialization of database on model changes.
			//using (var context = new SellContext()) {
			//	context.Database.Initialize(force: true);
			//}
			RegisterRoutes(RouteTable.Routes);
			
		}
		
		protected void Application_BeginRequest(object sender, System.EventArgs e)
        {
            CultureInfo culture = new CultureInfo("ru-RU");
                       System.Threading.Thread.CurrentThread.CurrentCulture = culture;
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
        }
		
		
	}
}
