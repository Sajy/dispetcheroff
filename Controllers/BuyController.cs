using System;
using System.Data.Entity;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;
using mvc2.Models;
using mvc2.Models.Grids;
using System.Linq;
using mvc2.Models.References;
namespace mvc2.Controllers
{
	/// <summary>
	/// Description of BuyController.
	/// </summary>
	public class BuyController : Controller
	{
		
			private readonly BuyContext ds = new BuyContext();
			
			public BuyController(){
					ViewBag.Contracts=ds.Contracts.ToList();
			}
		
		public ActionResult Index()
		{
				var model = from s in ds.Buys
				//join p in ds.Products on s.ProductId equals p.Id
				
				select new BuyGridModel {
				Id=s.Id,
				ProductName=s.Product.Name,
				ProductType=s.ProductType.Name,
				ProductQuality=s.Quality.Text,
				Date=s.Date,
				Price=s.Price,
				MinAmount=s.MinAmount,
				HoldArea=s.HoldArea.Name,
				Tel=s.Tel,
				Department=s.District.Department.Name
				
			};
			
			return View(model);
		}
		
		
		public ActionResult Edit(int id = 0)
		{
			TempData["UserMessage"] = null;
			Buy buy = ds.Buys.Find(id);
			
			if (buy==null) return RedirectToAction("Index");
			ViewBag.Title="Обновление объявления о продаже сельскохозяйственной продукции #"+buy.Id;
			ViewBag.ActionButtonText="Обновить";
			ViewBag.ActionButtonAction="Edit";
			//ViewBag.SelectedDistrict=sell.DistrictId;
			PopulateLists(buy);
			return View(buy);
		}
		
		[HttpPost]
		public ActionResult Edit(Buy model)
		{
			TempData["UserMessage"] = "Спасибо. Данные обновлены успешно. Они появятся после модерации в ближайшее время.";
			var buy=getBuy(model,true);
			ds.Buys.Attach(buy);
			ds.Entry(buy).State = EntityState.Modified;
			ds.SaveChanges();
			
			
			return RedirectToAction("Index");
		}
		
			
		public ActionResult Create(int id = 0)
		{
			TempData["UserMessage"] = null;
			if (id!=0) return RedirectToAction("Index"); 
				ViewBag.Title="Создание объявления о закупке сельскохозяйственной продукции";
				ViewBag.ActionButtonText="Создать";
				ViewBag.ActionButtonAction="Create";
				ViewBag.SelectedDistrict=1;
				ViewBag.IsCreate=true;
				
			
				
				PopulateLists(null);
				return  View();
		
		}
		
			//новое обявление
		[HttpPost]
		public ActionResult Create(Buy model)
		{
			
			TempData["UserMessage"] = "Спасибо. Данные сохранены успешно. Они появятся после модерации в ближайшее время.";
			var buy=getBuy(model,false);
			ds.Buys.Add(buy);
			ds.SaveChanges();
			return RedirectToAction("Index");
		}
		
		
		public ActionResult Delete(int id = 0)
		{
			
			TempData["UserMessage"] = "Данные удалены успешно.";
			Buy buy = ds.Buys.Find(id);
			if (buy==null) RedirectToAction("Index");
			ds.Buys.Remove(buy);
			ds.SaveChanges();
			return RedirectToAction("Index");
		}
		
			private void PopulateLists(Buy model)
		{
			var cu = new ContUtilsBuy(ds);
			ViewBag.ProductIdLb = cu.getListByType(ContUtilsBuy.DropDownListType.PopulateProduct, model);
			ViewBag.HoldAreaIdLb = cu.getListByType(ContUtilsBuy.DropDownListType.PopulateHoldArea, model);
			ViewBag.DistrictIdLb = cu.getListByType(ContUtilsBuy.DropDownListType.PopulateDistrict, model);
			ViewBag.DepartmentIdLb = cu.getListByType(ContUtilsBuy.DropDownListType.PopulateDepartment, model);
			ViewBag.ProductTypeIdLb = cu.getListByType(ContUtilsBuy.DropDownListType.PopulateProductType, model);
			ViewBag.QualityIdLb = cu.getListByType(ContUtilsBuy.DropDownListType.PopulateQuality, model);
		}
			
			public JsonResult GetDistrictsByDepId(int Id )
		{
			
		var districtQuery = from s in ds.Districts
				join p in ds.Departments on s.DepartmentId equals p.Id
				where s.DepartmentId==Id
				select new DistrictInDep { Id = s.Id, Name = s.Name };

			return Json(new SelectList(districtQuery, "Id", "Name"));
		}
			
		private Buy getBuy(Buy model,bool yesId){
			var buy = new Buy();
			if (yesId) buy.Id=model.Id;
			buy.ProductId = model.ProductId;
			buy.Price = model.Price;
			buy.Amount = model.Amount;
			buy.MinAmount=model.MinAmount;
			buy.Date = DateTime.Now;
			buy.DistrictId = model.DistrictId;
			buy.HoldAreaId = model.HoldAreaId;
			buy.ProductTypeId = model.ProductTypeId;
			buy.QualityId = model.QualityId;
			buy.Tel=model.Tel;
			return buy;
		}
		
	}
}