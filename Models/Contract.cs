/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 20:21
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Models
{
	/// <summary>
	/// Description of Contract.
	/// </summary>
	
	[Table("contract")]
	public class Contract
	{
		
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Display(Name = "Текст контратка")]
		public string Text { get; set; }
	}
}
