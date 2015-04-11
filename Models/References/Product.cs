/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 13.03.2015
 * Время: 23:39
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace mvc2.Models.References
{
	/// <summary>
	/// Description of Product.
	/// </summary>
	[Table("product")]
	public class Product
	{
		
		
		
		public int Id {get;set;}
		public string Name {get;set;}
		public string Description {get;set;}
		
		
		
	}
}
