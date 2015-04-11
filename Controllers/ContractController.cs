using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;
using mvc2.Models;
using mvc2.Models.Grids;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of ContractController.
	/// </summary>
	public class ContractController : Controller
	{
		
		private readonly SellContext ds = new SellContext();
		
		public ContractController(){
			ViewBag.Contracts=ds.Contracts.ToList();
		}
		
		public ActionResult Index()
		{
			var model = from s in ds.Contracts
				
				select new ContractGridModel {
				Id=s.Id,
				Text = s.Text
				
			};
			return View(model);
		}
		
		public ActionResult Create(int id = 0)
		{
				TempData["UserMessage"] = null;
				if (id!=0) return RedirectToAction("Index"); 
				ViewBag.Title="Создание нового предложения (контракта)";
				ViewBag.ActionButtonText="Создать";
				ViewBag.ActionButtonAction="Create";
				ViewBag.SelectedDistrict=1;
				ViewBag.IsCreate=true;
				return  View();
			
			
		}
		
			//новое обявление
		[HttpPost]
		public ActionResult Create(Contract model)
		{
			
			TempData["UserMessage"] = "Данные созданы успешно.";
			var contract=getContract(model,false);
			
			ds.Contracts.Add(contract);
			ds.SaveChanges();
			
			return RedirectToAction("Index");
		}
		
		
		public ActionResult Edit(int id = 0)
		{
				TempData["UserMessage"] = null;
			Contract contract = ds.Contracts.Find(id);
			if (contract==null) return RedirectToAction("Index");
			ViewBag.Title="Обновление контракта #"+contract.Id;
			ViewBag.ActionButtonText="Обновить";
			ViewBag.ActionButtonAction="Edit";
			return View(contract);
		}
		
		
		
		public ActionResult Delete(int id = 0)
		{
			
			TempData["UserMessage"] = "Данные удалены успешно.";
			Contract contract = ds.Contracts.Find(id);
			if (contract==null) RedirectToAction("Index");
			ds.Contracts.Remove(contract);
			ds.SaveChanges();
			return RedirectToAction("Index");
		}
		
		[HttpPost]
		public ActionResult Edit(Contract model)
		{
			TempData["UserMessage"] = "Данные обновлены успешно.";
			var contract=getContract(model,true);
			
			Contract existing = ds.Contracts.Find(model.Id);
    		((IObjectContextAdapter)ds).ObjectContext.Detach(existing);
			
			 
			
			 ds.Contracts.Attach(contract);
			ds.Entry(contract).State = EntityState.Modified;
			//ds.Entry(model).CurrentValues.SetValues(contract);
			ds.SaveChanges();
			
			
			return RedirectToAction("Index");
		}
		
		
		
		private Contract getContract(Contract model,bool yesId){
			var contract = new Contract();
			if (yesId) contract.Id=model.Id;
			contract.Text = model.Text;
			
			return contract;
		}

		
	}
}