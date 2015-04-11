/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 13.03.2015
 * Время: 23:35
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using mvc2.Models.References;
using System.Collections.Generic;

namespace mvc2.Models
{
	/// <summary>
	/// Description of Sell.
	/// </summary>
	/// 
	[Table("sell")]
	public class Sell
	{
	
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		
		[Display(Name = "Продукт")]
		[ValidateSelection(ErrorMessage = "Выберите продукт из списка")]
		public int ProductId { get; set; }
		public virtual Product Product { get; set; }
		
	
		[Display(Name = "Тип продукта")]
		[ValidateSelection(ErrorMessage = "Выберите тип продукта из списка")]
		public int ProductTypeId { get; set; }
		public virtual  ProductType  ProductType { get; set; }
		
		[Display(Name = "Район")]
		[ValidateSelection(ErrorMessage = "Выберите район из списка")]
		public int DistrictId { get; set; }
		public virtual District District { get; set; }
		
		[Display(Name = "Место хранения")]
		[ValidateSelection(ErrorMessage = "Выберите место хранения из списка")]
		public int HoldAreaId { get; set; }
		public virtual HoldArea HoldArea { get; set; }
		
		[Display(Name = "Качество")]
		public int QualityId { get; set; }
		public virtual Quality Quality { get; set; }
		
		[Required(ErrorMessage = "Требуется ввести цену")]
		[Display(Name = "Цена")]
		public double Price { get; set; }
		
		[Required(ErrorMessage = "Требуется ввести Количество")]
		[Display(Name = "Количество")]
		public double Amount { get; set; }
		
		[Display(Name = "Город")]
		public string City { get; set; }
		
		[Required(ErrorMessage = "Требуется ввести Телефон")]
		[Display(Name = "Телефон")]
		public string Tel { get; set; }
		
		[Display(Name = "Дата")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
		[ValidateDate(ErrorMessage = "Дата должна быть не больше сегодняшней")]
		public DateTime Date { get; set; }
		
	
		public class ValidateSelection : ValidationAttribute
		{
			public override bool IsValid(object value)
			{
				int index = (int)value;
				if (index == -1)
					return false;
				else
					return true;
				
			}
		}
		
		public class ValidateDate : ValidationAttribute
		{
			public override bool IsValid(object value)
			{
				
			//	if (((DateTime)value).Date > DateTime.Today)
			//		return false;
			//	else
					return true;
				
			}
		}
		
		
		
		
	}
	

	
	
	
}
