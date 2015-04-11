using System;
using System.Linq;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;
using mvc2.Models;
using System.Data.Entity;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of Shop.
	/// </summary>
	public class ShopController : Controller
	{
		private readonly SellContext ds = new SellContext();
			
			
		public ShopController(){
				ViewBag.Contracts=ds.Contracts.ToList();
		}
		
		DispDataContext db = new DispDataContext();
		
		public ActionResult Index()
		{
			return View();
		}
		
		public ActionResult Show(){
			return View(db.Auctions.ToList());
		}
		
		[HttpGet]
		public ActionResult Create(int id = 0)
		{
			Auction auction = db.Auctions.Find(id);
			if (auction==null) return HttpNotFound();
			return View(auction);
		}
		
		[HttpPost]
		public ActionResult Create(Auction auction)
		{
			
//			if (auction.EndTime==null)
//			{
//				ModelState.AddModelError(
//					"EndTime",
//					"Аукцион должен быть длино больше 1 го дня"
//				);
//			}
			
			if (ModelState.IsValid){
				//db.Auctions.Add(auction);
				db.Entry(auction).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}else return View(auction);
		}
	}

}