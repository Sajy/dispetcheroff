/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 22.03.2015
 * Время: 20:01
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using mvc2.Infrastructure.Db;
using mvc2.Models;
using mvc2.Models.References;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of ContUtils.
	/// </summary>
	public class ContUtils
	{
		private const string Id="Id";
		private const string Name="Name";
		
		public enum DropDownListType {PopulateProduct, PopulateDistrict, PopulateDepartment,
			PopulateHoldArea, PopulateProductType, PopulateQuality};
		
		
		private readonly SellContext ds;


		
		public ContUtils(SellContext ds)
		{
			
			this.ds=ds;
			
		}
		
		public  SelectList getListByType(DropDownListType t, Sell model){
			object selectedProduct=null;
			switch (t){
				case DropDownListType.PopulateProduct:
					if (model!=null)  selectedProduct=model.ProductId;
					List<Product> l = ds.Products.OrderBy(d => d.Name).ToList();
					l.Add(new Product{Id=-1,Name="Выберите продукт..."});
					return new  SelectList(l, Id, Name, selectedProduct);
				case DropDownListType.PopulateDistrict:
					if (model!=null) selectedProduct=model.DistrictId;
					List<District> dd = ds.Districts.OrderBy(v => v.Name).ToList();
					dd.Add(new District{Id=-1,Name="Выберите район...",DepartmentId=-1});
					return new  SelectList(dd, Id, Name, selectedProduct);
				case DropDownListType.PopulateDepartment:
					if (model!=null) selectedProduct=model.District.DepartmentId;
					List<Department> dp = ds.Departments.OrderBy(v => v.Name).ToList();
					dp.Add(new Department{Id=-1,Name="Выберите область..."});
					return new  SelectList(dp, Id,Name,selectedProduct);
				case DropDownListType.PopulateHoldArea:
					if (model!=null) selectedProduct=model.HoldAreaId;
					List<HoldArea> ha = ds.HoldAreas.OrderBy(d => d.Name).ToList();
					ha.Add(new HoldArea{Id=-1,Name="Выберите место хранения..."});
					return new  SelectList(ha, Id, Name, selectedProduct);
				case DropDownListType.PopulateProductType:
					if (model!=null) selectedProduct=model.ProductTypeId;
					List<ProductType> pt = ds.ProductTypes.OrderBy(d => d.Name).ToList();
					pt.Add(new ProductType{Id=-1,Name="Выберите тип продукта..."});
					return new  SelectList(pt, Id, Name, selectedProduct);
				case DropDownListType.PopulateQuality:
					if (model!=null) selectedProduct=model.QualityId;
					return new  SelectList(ds.Qualities.OrderBy(d => d.Text), Id, "Text", selectedProduct);
			}
			return null;
		}
		
		
		


		
	}
}
