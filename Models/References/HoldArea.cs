/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 16.03.2015
 * Время: 10:48
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Models.References
{
	/// <summary>
	/// Description of HoldArea.
	/// </summary>
	/// 
	[Table("holdarea")]
	public class HoldArea
	{
		
		
	
		public int Id {get;set;}
		public string Name {get;set;}
		
		
	}
}
