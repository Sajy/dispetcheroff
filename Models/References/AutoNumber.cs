/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 26.03.2015
 * Время: 20:44
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace mvc2.Models.References
{
	/// <summary>
	/// Description of AutoNumber.
	/// </summary>
	/// 
	[Table("autonumber")]
	public class AutoNumber
	{
		
		public int Id {get;set;}
		
		[Display(Name = "Госномер")]
		public string NumberText {get;set;}
		
		
		public int TransportId {get;set;}
		public virtual Transport Transport {get;set;}
		[Display(Name = "Марка")]
		public int NumAutoModelId { get; set; }
		[Display(Name = "Тип")]
		public int NumAutoTypeId { get; set; }
		
		

		 
		
		
	}
}
