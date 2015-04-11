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
	/// Description of AutoModel.
	/// </summary>
	[Table("automodel")]
	public class AutoModel
	{
		
		public int Id {get;set;}
		public string Name {get;set;}
		
		
	}
}
