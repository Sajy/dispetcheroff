/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 09.04.2015
 * Время: 11:16
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace mvc2.Models.Grids
{
	/// <summary>
	/// Description of DetailsAnGrid.
	/// </summary>
	public class DetailsAnGrid
	{
		
		[Display(Name = "Марка")]
		public string AutoModel { get; set; }
		[Display(Name = "Тип")]
		public string AutoType { get; set; }
		[Display(Name = "Госномер")]
		public string AutoNumber { get;set; }
		
	}
}
