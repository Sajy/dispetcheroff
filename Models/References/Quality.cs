/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 16.03.2015
 * Время: 10:43
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace mvc2.Models.References
{
	/// <summary>
	/// Description of Quality.
	/// </summary>
	/// 
	[Table("quality")]
	public class Quality
	{
		
		
		
		public int Id {get;set;}
		public string Text {get;set;}
		
		
		public Quality()
		{
		}
	}
}
