/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 23.03.2015
 * Время: 22:55
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Linq;
using mvc2.Models.Grids;

namespace mvc2.Models.Utils
{
	/// <summary>
	/// Description of ServiceData.
	/// </summary>
	public class ServiceData
	{
		public enum SortingOrder {ProductAsc,ProductDsc, DateAsc, DateDsc, QtyAsc, QtyDsc, PriceAsc, PriceDsc, DeptAsc, DeptDsc};
//		private int FilterByProductId;
//		private int FilterByDepartmentId;
//		private SortingOrder sortingOrder;
//	
		
		IQueryable<SellGridModel> model;
		
		public ServiceData(IQueryable<SellGridModel> model)
		{
			this.model =model;
		}
		
		public IQueryable<SellGridModel> getSortedModel(SortingOrder sortingOrder){
			switch (sortingOrder) {
				case SortingOrder.DateAsc:
					return model.OrderBy(s => s.Date); //сортировка по дате а-я
				case SortingOrder.DateDsc:
					return model.OrderByDescending(s => s.Date); //сортировка по дате я-а
					
				case SortingOrder.ProductDsc:
					return model.OrderByDescending(p => p.Name); //сортировка по товару я-а
				case SortingOrder.ProductAsc:
					return model.OrderBy(p => p.Name); //сортировка по товару а-я
					
					
				case SortingOrder.QtyDsc:
					return model.OrderByDescending(p => p.Amount); //сортировка по к-ву я-а
				case SortingOrder.QtyAsc:
					return model.OrderBy(p => p.Amount); //сортировка по к-ву а-я
				case SortingOrder.PriceDsc:
					return model.OrderByDescending(p => p.Price); //сортировка по цене я-а
				case SortingOrder.PriceAsc:
					return model.OrderBy(p => p.Price); //сортировка по цене а-я
				case SortingOrder.DeptDsc:
					return model.OrderByDescending(p => p.Department); //сортировка по области я-а
				case SortingOrder.DeptAsc:
					return model.OrderBy(p => p.Department); //сортировка по области а-я					
			}
			return null;
			
		}
		
		public static SortingOrder getProductOrder(SortingOrder sortingOrder){
			 return sortingOrder==ServiceData.SortingOrder.ProductAsc ? ServiceData.SortingOrder.ProductDsc : ServiceData.SortingOrder.ProductAsc;
		}
		
		public static SortingOrder getDateOrder(SortingOrder sortingOrder){
			 return sortingOrder == ServiceData.SortingOrder.DateAsc ? ServiceData.SortingOrder.DateDsc : ServiceData.SortingOrder.DateAsc;
		}
		
		public static SortingOrder getQtyOrder(SortingOrder sortingOrder){
			 return sortingOrder == ServiceData.SortingOrder.QtyAsc ? ServiceData.SortingOrder.QtyDsc : ServiceData.SortingOrder.QtyAsc;
		}
		
		public static SortingOrder getPriceOrder(SortingOrder sortingOrder){
			 return sortingOrder == ServiceData.SortingOrder.PriceAsc ? ServiceData.SortingOrder.PriceDsc : ServiceData.SortingOrder.PriceAsc;
		}
		
		public static SortingOrder getDeptOrder(SortingOrder sortingOrder){
			 return sortingOrder == ServiceData.SortingOrder.DeptAsc ? ServiceData.SortingOrder.DeptDsc : ServiceData.SortingOrder.DeptAsc;
		}
	}
	
}
