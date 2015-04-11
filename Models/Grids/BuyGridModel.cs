/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 11:05
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace mvc2.Models.Grids
{
	/// <summary>
	/// Description of BuyGridModel.
	/// </summary>
	public class BuyGridModel
	{
		
		public int Id { get; set; }
		public int ProductId { get; set; }
		[Display(Name = "Товар")]
		public string ProductName { get; set; }
		public int ProductTypeId { get; set; }
		[Display(Name = "Тип товара")]
		public string ProductType { get; set; }
		public int QualityId { get; set; }
		[Display(Name = "Качество")]
		public string ProductQuality { get; set; }
		public int DepartmentId { get; set; }
		[Display(Name = "Область")]
		public string Department { get; set; }
		public int HoldAreaId { get; set; }
		[Display(Name = "Место хранения")]
		public string HoldArea { get; set; }
		[Display(Name = "Мин. партия")]
		public double MinAmount { get; set; }
		[Display(Name = "Цена")]
		public double Price { get; set; }
		[Display(Name = "Дата")]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }
		[Display(Name = "Телефон")]
		public string Tel { get; set; }
		
		
	
		

	
	}
}
