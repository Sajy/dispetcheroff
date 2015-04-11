/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 14.03.2015
 * Время: 23:18
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace mvc2.Models.Grids
{
	/// <summary>
	/// Description of SellGridModel.
	/// </summary>
	public class SellGridModel
	{
		
		public int Id { get; set; }
		public int ProductId { get; set; }
		[Display(Name = "Товар")]
		public string Name { get; set; }
		
		[Display(Name = "Количество")]
		public double Amount { get; set; }
		[Display(Name = "Цена")]
		public double Price { get; set; }
		
		public int DepartmentId { get; set; }
		[Display(Name = "Область")]
		public string Department { get; set; }
		
		[Display(Name = "Дата")]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }
		
			
	}
}
