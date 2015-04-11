using System;
using System.Linq;
using System.Web.Mvc;

using System.Web.Security;
using mvc2.Infrastructure.Db;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of AccountController.
	/// </summary>
	public class AccountController : Controller
	{
		Abstract.IAuthProvider authProvider;
		private readonly BuyContext ds = new BuyContext();
		
	
		
		
		public AccountController() {
				ViewBag.Contracts=ds.Contracts.ToList();
		}
		public AccountController(Abstract.IAuthProvider auth) {
			authProvider = auth;
		}
		
		public ActionResult Login()
		{
			
			return View();
		}
		
//		public ActionResult LogOff()
//		{
//			return View();
//		}
		
		public ActionResult PersonalArea(){
			
			return View();
		}
		
		public ActionResult Registration(){
		
			return View();
		}
	
	 	public ActionResult Logoff()
		{
			FormsAuthentication.SignOut();
            return RedirectToAction("", "Home");
		}
		
		[HttpPost]
		public ActionResult Login(Models.LoginViewModel model, string returnUrl) {
			if (ModelState.IsValid) {
				if (Authenticate(model.UserName, model.Password)) {
					return Redirect(returnUrl ?? Url.Action("PersonalArea", "Account")); //Куда заходим после логина
				} else {
					ModelState.AddModelError("", "Неверное имя или пароль. Повторите попытку.");
					return View();
				}
			} else {
				return View();
			}
		}
		
		public bool Authenticate(string username, string password)
		{
			
			//bool result = FormsAuthentication.Authenticate(username, password);
			bool result = Membership.ValidateUser(username, password);
			if (result) {
				FormsAuthentication.SetAuthCookie(username, false);
			}
			return result;
		}
	}
}