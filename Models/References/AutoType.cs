/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 26.03.2015
 * Время: 10:58
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Models.References
{
	/// <summary>
	/// Description of AutoType.
	/// </summary>
	
	[Table("autotype")]
	public class AutoType
	{
		
		
		public int Id {get;set;}
		public string Name {get;set;}
		
		
	}
}
