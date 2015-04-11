using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Web.Mvc;
using System.Collections.Generic;
using mvc2.Infrastructure.Db;
using mvc2.Models.References;
using mvc2.Models;
using mvc2.Models.Grids;
using mvc2.Models.Utils;


namespace mvc2.Controllers
{
	/// <summary>
	/// Description of SellController.
	/// </summary>
	public class SellController : Controller
	{
		
		private readonly SellContext ds = new SellContext();
		
		public SellController()
		{
			
			ViewBag.Contracts = ds.Contracts.ToList();
		}
		
		
		
		public ActionResult Index(ServiceData.SortingOrder sortingOrder = ServiceData.SortingOrder.DateDsc, int FiltProdId = 0, int FiltDepId = 0)
		{
			
			
			
			var model = from s in ds.Sells
			            join p in ds.Products on s.ProductId equals p.Id
			            select new SellGridModel {
				Id = s.Id,
				Name = p.Name,
				ProductId = p.Id,
				DepartmentId = s.District.DepartmentId,
				Amount = s.Amount,
				Price = s.Price,
				Date = s.Date,
				Department = s.District.Department.Name
			};
			
			
			
			if (FiltProdId != 0)
				model = model.Where(x => x.ProductId == FiltProdId);
			if (FiltDepId != 0)
				model = model.Where(x => x.DepartmentId == FiltDepId);
			ViewBag.FiltProdId = FiltProdId;
			ViewBag.FiltDepId = FiltDepId;
			
			
			
			//заполняем данными списки для фильтрации
			var cu = new ContUtils(ds);
			ViewBag.ProductId = cu.getListByType(ContUtils.DropDownListType.PopulateProduct, null);
			ViewBag.DepartmentId = cu.getListByType(ContUtils.DropDownListType.PopulateDepartment, null);
			
			
			
			
			
			//сортировка
			ViewBag.SortingByProduct = ServiceData.getProductOrder(sortingOrder);
			ViewBag.SortingByDate = ServiceData.getDateOrder(sortingOrder);
			ViewBag.SortingByQty = ServiceData.getQtyOrder(sortingOrder);
			ViewBag.SortingByPrice = ServiceData.getPriceOrder(sortingOrder);
			ViewBag.SortingByDept = ServiceData.getDeptOrder(sortingOrder);
			model = new ServiceData(model).getSortedModel(sortingOrder);
			return View(model);
		}
		
		public JsonResult GetDistrictsByDepId(int Id)
		{
			
			var districtQuery = from s in ds.Districts
			                    join p in ds.Departments on s.DepartmentId equals p.Id
			                    where s.DepartmentId == Id
			                    select new DistrictInDep { Id = s.Id, Name = s.Name };
			if (Id == -1) {
				List<District> t = new List<District>();
				t.Add(new District {
					Id = -1,
					Name = "Выберите район...",
					DepartmentId = -1
				});
				return Json(new SelectList(t, "Id", "Name"));
			}

			return Json(new SelectList(districtQuery, "Id", "Name"));
		}
		
		
		public ActionResult Delete(int id = 0)
		{
			
			TempData["UserMessage"] = "Данные удалены успешно.";
			Sell sell = ds.Sells.Find(id);
			if (sell == null)
				RedirectToAction("Index");
			ds.Sells.Remove(sell);
			ds.SaveChanges();
			return RedirectToAction("Index");
		}
		
		
		//редактирвоание
		
		
		
		
		public ActionResult Create(int id = 0)
		{
			
			TempData["UserMessage"] = null;
			if (id != 0)
				return RedirectToAction("Index");
			ViewBag.Title = "Создание объявления о продаже сельскохозяйственной продукции";
			ViewBag.ActionButtonText = "Создать";
			ViewBag.ActionButtonAction = "Create";
			ViewBag.SelectedDistrict = 1;
			ViewBag.IsCreate = true;
			Sell sell = new Sell();
			sell.Date = DateTime.Now;
			sell.ProductId = -1;
			sell.ProductTypeId = -1;
			sell.HoldAreaId = -1;
			sell.District = new District{ Id = -1, DepartmentId = -1 };
			
			
			PopulateLists(sell);
			return  View(sell);
			
			
		}
		
		
		//новое обявление
		[HttpPost]
		public ActionResult Create(Sell model)
		{
			
			
			
			TempData["UserMessage"] = "Спасибо. Данные сохранены успешно. Они появятся после модерации в ближайшее время.";
			var sell = getSell(model, false);
			
			ds.Sells.Add(sell);
			
			if (ModelState.IsValid) {
				ds.SaveChanges();
				
				return RedirectToAction("Index");
			} else {
				TempData["UserMessage"] = null;
				PopulateLists(null);
				return View(model);
			}
		}
		
		public ActionResult Edit(int id = 0)
		{
			TempData["UserMessage"] = null;
			Sell sell = ds.Sells.Find(id);
			
			if (sell == null)
				return RedirectToAction("Index");
			ViewBag.Title = "Обновление объявления о продаже сельскохозяйственной продукции #" + sell.Id;
			ViewBag.ActionButtonText = "Обновить";
			ViewBag.ActionButtonAction = "Edit";
			ViewBag.SelectedDistrict = sell.DistrictId;
			PopulateLists(sell);
			return View(sell);
		}
		
		
		[HttpPost]
		public ActionResult Edit(Sell model)
		{
			TempData["UserMessage"] = "Спасибо. Данные обновлены успешно. Они появятся после модерации в ближайшее время.";
			var sell = getSell(model, true);
			ds.Sells.Attach(sell);
			ds.Entry(sell).State = EntityState.Modified;
			ds.SaveChanges();
			
			
			return RedirectToAction("Index");
		}
		
		
		
		private void PopulateLists(Sell model)
		{
			var cu = new ContUtils(ds);
			ViewBag.ProductIdLb = cu.getListByType(ContUtils.DropDownListType.PopulateProduct, model);
			ViewBag.HoldAreaIdLb = cu.getListByType(ContUtils.DropDownListType.PopulateHoldArea, model);
			ViewBag.DistrictIdLb = cu.getListByType(ContUtils.DropDownListType.PopulateDistrict, model);
			ViewBag.DepartmentIdLb = cu.getListByType(ContUtils.DropDownListType.PopulateDepartment, model);
			ViewBag.ProductTypeIdLb = cu.getListByType(ContUtils.DropDownListType.PopulateProductType, model);
			ViewBag.QualityIdLb = cu.getListByType(ContUtils.DropDownListType.PopulateQuality, model);
		}
		
		private Sell getSell(Sell model, bool yesId)
		{
			var sell = new Sell();
			if (yesId)
				sell.Id = model.Id;
			sell.ProductId = model.ProductId;
			
			sell.Price = model.Price;
			sell.Amount = model.Amount;
			sell.Date = DateTime.Now;
			sell.DistrictId = model.DistrictId;
			sell.HoldAreaId = model.HoldAreaId;
			sell.ProductTypeId = model.ProductTypeId;
			sell.QualityId = model.QualityId;
			sell.City = model.City;
			sell.Tel = model.Tel;
			return sell;
		}
		
		
		
	}
}