/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 26.03.2015
 * Время: 11:11
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using mvc2.Models.References;

namespace mvc2.Models.Grids
{
	/// <summary>
	/// Description of TransportGridModel.
	/// </summary>
	public class TransportGridModel
	{
		public int Id { get; set; }
		public int AutoModelId { get; set; }
		[Display(Name = "Марка")]
		public string AutoModelName { get; set; }
		[Display(Name = "Количество авто")]
		public int AutosQuantity { get; set; }
		public int AutoTypeId { get; set; }
		[Display(Name = "Тип")]
		public string AutoTypeName { get; set; }
		[Display(Name = "Госномер")]
		public  List<AutoNumber> AutoNumbers { get; set; }
		[Display(Name = "Телефон")]
		public string Tel { get; set; }
		[Display(Name = "Почта")]
		public string Email { get; set; }
		[Display(Name = "Дата")]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		public DateTime Date { get; set; }
	}
}
