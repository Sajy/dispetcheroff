using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;

using System.Net.Mime;
using System.Security.Principal;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;
using mvc2.Models;
using mvc2.Models.Grids;
using mvc2.Models.References;
using System.Linq;
namespace mvc2.Controllers
{
	/// <summary>
	/// Description of SellTransportController.
	/// </summary>
	public class TransportController : Controller
	{
		
		private readonly TransportContext ds = new TransportContext();
		
		
		public TransportController()
		{
			ViewBag.Contracts = ds.Contracts.ToList();
			
			ViewBag.Autonums = new List<AutoNumber>{ };
			
		}
		
		
		public ActionResult Row( int id, int transportId)
		{
			PopulateLists(null);
			@ViewBag.Index = id+1;
			@ViewBag.xxx = transportId;
			Transport model = ds.Transports.Find(transportId); // а если null?
			
			if (model==null) {
					model = new Transport();
					model.AutoNumbers = new List<AutoNumber>{ };
				
			}
			model.AutoNumbers.Add(new AutoNumber{});
			model.AutoModelList= ds.AutoModels.OrderBy(d => d.Name).ToList();
			model.AutoTypeList=ds.AutoTypes.OrderBy(d => d.Name).ToList();		
			model.AutoTypeList.Add(new AutoType{Id=-1,Name="Выберите тип авто..."});
			model.AutoModelList.Add(new AutoModel{Id=-1,Name="Выберите модель авто..."});
			
			ViewBag.Rows=model.AutoNumbers;
			
			
			
			
			return PartialView(model);
		}
		
		public ActionResult Details(int id)
		{
			
				var model = from s in ds.AutoNumbers
				join p in ds.AutoTypes on s.NumAutoTypeId equals p.Id
				join k in ds.AutoModels on s.NumAutoModelId equals k.Id
				where s.TransportId==id
				select new DetailsAnGrid {AutoModel=k.Name, AutoType=p.Name, AutoNumber=s.NumberText  };

			
			
			//Transport model = ds.Transports.Find(id);
			
			return PartialView(model);
		}
		
		public ActionResult Index()
		{
			
		
			var model = ds.Transports.Select(s => new TransportGridModel {
				Id = s.Id,
				AutosQuantity = s.AutosQuantity,
				Tel = s.Tel,
				Date = s.Date,
				Email = s.Email
			});
			
			
			return View(model);
		}
		
		
		
		
		
		[HttpGet]
		public ActionResult Create()
		{
			
			
			
			TempData["UserMessage"] = null;
			var transport = new Transport();
			transport.AutoNumbers = new List<AutoNumber>{ };
			transport.Date=DateTime.Now;
			ViewBag.Rows=transport.AutoNumbers;
			@ViewBag.Title = "Регистрация транспорта";
			@ViewBag.ActionButtonText = "Зарегистрироваться";
			//ViewBag.AutoTypesCb = ds.AutoTypes.OrderBy(d => d.Name);
			PopulateLists(null);
			

			return View(transport);
			
			
			
			
			
		}
		
		
		private Transport fillAutoLists(Transport transport){
			transport.AutoModelList= ds.AutoModels.OrderBy(d => d.Name).ToList();
			transport.AutoTypeList=ds.AutoTypes.OrderBy(d => d.Name).ToList();	
			return transport;
		}
		
		public ActionResult Edit(int id = 0)
		{
			
			TempData["UserMessage"] = null;
			Transport transport = ds.Transports.Find(id);
			if (transport == null)
				return RedirectToAction("Index");
			ViewBag.Title = "Обновление объявления о предоставлении транспорта #" + transport.Id;
			ViewBag.ActionButtonText = "Обновить объявление";
			ViewBag.Rows=transport.AutoNumbers;
					
			
			PopulateLists(null);
		
			int count = transport.AutoNumbers.Count;

			
			
			return View(fillAutoLists(transport));
		}
		
		
		[HttpPost]
			
			
		public ActionResult Edit(Transport transport)
		{
			
			TempData["UserMessage"] = "Спасибо. Данные обновлены успешно. Они появятся после модерации в ближайшее время.";
			List<AutoNumber> dan = (from n in ds.AutoNumbers
				                       where n.TransportId == transport.Id
				                       select n).ToList();
				foreach (AutoNumber del in dan) {
					ds.AutoNumbers.Remove(del);
					ds.Entry(del).State = EntityState.Deleted;
			}
			if (transport.AutoNumbers != null) {
				
				
				
			
				foreach (AutoNumber an in transport.AutoNumbers) {
					ds.AutoNumbers.Add(an);
				}
			} else transport.AutoNumbers=new List<AutoNumber>{}; 
			
			ds.Transports.Attach(transport);
			ds.Entry(transport).State = EntityState.Modified;
			
			if (ModelState.IsValid){
			ds.SaveChanges();
			return RedirectToAction("Index");
			} else {
				TempData["UserMessage"] = null;
				ViewBag.Rows=transport.AutoNumbers;
				PopulateLists(null);
				return  View(fillAutoLists(transport));
			}
		}
		
		
		[HttpPost]
		public ActionResult Create(Transport model)
		{
			
			TempData["UserMessage"] = "Спасибо. Данные сохранены успешно. Они появятся после модерации в ближайшее время.";
			var transport = getTransport(model, false);
			ds.Transports.Add(transport);
			
			if (ModelState.IsValid){
			ds.SaveChanges();
			return RedirectToAction("Index");} else {
				TempData["UserMessage"] = null;
				transport.AutoNumbers = new List<AutoNumber>{ };
				ViewBag.Rows=transport.AutoNumbers;
				PopulateLists(null);
				return  View(fillAutoLists(transport));
			}
		}
		
		public ActionResult Delete(int id = 0)
		{
			TempData["UserMessage"] = "Данные удалены успешно.";
			Transport transport = ds.Transports.Find(id);
			if (transport == null)
				RedirectToAction("Index");
			ds.Transports.Remove(transport);
			ds.SaveChanges();
			return RedirectToAction("Index");
		}
		
		private void PopulateLists(AutoNumber model)
		{
			var cu = new ContUtilsTrans(ds);
			ViewBag.AutoModelIdLb = cu.getListByType(ContUtilsTrans.DropDownListType.PopulateAutoModel, model);
			ViewBag.AutoTypeIdLb = cu.getListByType(ContUtilsTrans.DropDownListType.PopulateAutoType, model);
			
		
		}
		
		private Transport getTransport(Transport model, bool yesId)
		{
			var transport = new Transport();
			if (yesId)
				transport.Id = model.Id;
			transport.AutoModelId = model.AutoModelId;
			transport.AutoTypeId = model.AutoTypeId;
			transport.Date = DateTime.Now;
			transport.Tel = model.Tel;
			transport.Email = model.Email;
			transport.AutoNumbers = model.AutoNumbers;
			transport.AutosQuantity=model.AutosQuantity;
			
			
			return transport;
		}
		
	}
}