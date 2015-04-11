/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 9:19
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using mvc2.Models.References;

namespace mvc2.Models
{
	/// <summary>
	/// Description of Buy.
	/// </summary>
	
	[Table("buy")]
	public class Buy
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Display(Name = "Район")]
		public int DistrictId { get; set; }
		public virtual District District { get; set; }
		[Display(Name = "Товар")]
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		[Display(Name = "Тип товара")]
		public int ProductTypeId { get; set; }
		public virtual  ProductType  ProductType { get; set; }
		[Display(Name = "Качество")]
		public int QualityId { get; set; }
		public virtual  Quality Quality { get; set; }
		[Display(Name = "Место хранения")]
		public int HoldAreaId { get; set; }
		public virtual HoldArea HoldArea { get; set; }
		[Display(Name = "Объем")]
		public double Amount { get; set; }
		[Display(Name = "Цена")]
		public double Price { get; set; }
		[Display(Name = "Минимальный объем")]
		public double MinAmount { get; set; }
		[Display(Name = "Телефон")]
		public string Tel { get; set; }
		[Display(Name = "Дата")]
		public DateTime Date { get; set; }
	}
}
