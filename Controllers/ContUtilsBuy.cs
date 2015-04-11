/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 12:15
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Linq;
using System.Web.Mvc;
using mvc2.Infrastructure.Db;
using mvc2.Models;

namespace mvc2.Controllers
{
	/// <summary>
	/// Description of ContUtilsBuy.
	/// </summary>
	public class ContUtilsBuy
	{
			private const string Id="Id";
		private const string Name="Name";
		
		public enum DropDownListType {PopulateProduct, PopulateDistrict, PopulateDepartment,
			PopulateHoldArea, PopulateProductType, PopulateQuality};
		
		
		private readonly BuyContext ds;

		public ContUtilsBuy(BuyContext ds)
		{
				this.ds=ds;
		}
		
		public  SelectList getListByType(DropDownListType t, Buy model){
			object selectedProduct=null;
			switch (t){
				case DropDownListType.PopulateProduct:
					if (model!=null)  selectedProduct=model.ProductId;
					return new  SelectList(ds.Products.OrderBy(d => d.Name), Id, Name, selectedProduct);
				case DropDownListType.PopulateDistrict:
					if (model!=null) selectedProduct=model.DistrictId;
					return new  SelectList(ds.Districts.OrderBy(v => v.Name), Id, Name, selectedProduct);
				case DropDownListType.PopulateDepartment:
					if (model!=null) selectedProduct=model.District.DepartmentId;
					return new  SelectList(ds.Departments.OrderBy(v => v.Name), Id,Name,selectedProduct);
				case DropDownListType.PopulateHoldArea:
					if (model!=null) selectedProduct=model.HoldAreaId;
					return new  SelectList(ds.HoldAreas.OrderBy(d => d.Name), Id, Name, selectedProduct);
				case DropDownListType.PopulateProductType:
					if (model!=null) selectedProduct=model.ProductTypeId;
					return new  SelectList(ds.ProductTypes.OrderBy(d => d.Name), Id, Name, selectedProduct);
				case DropDownListType.PopulateQuality:
					if (model!=null) selectedProduct=model.QualityId;
					return new  SelectList(ds.Qualities.OrderBy(d => d.Text), Id, "Text", selectedProduct);
				
			}
			return null;
		}
	}
}
