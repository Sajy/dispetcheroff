/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 16.03.2015
 * Время: 10:45
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mvc2.Models.References
{
	/// <summary>
	/// Description of District.
	/// </summary>
	/// 
	[Table("district")]
	public class District
	{
		
		
		
		public int Id {get;set;}
		public string Name {get;set;}
		
		[Display(Name = "Область")]
		[ValidateSelection(ErrorMessage="Выберите область из списка")]
		public int DepartmentId {get;set;}
		public virtual Department Department {get;set;}
		public District()
		{
		}
		public class ValidateSelection : ValidationAttribute
		{
			public override bool IsValid(object value)
			{
				int index = (int)value;
				if (index==-1) return false; else return true;
				
			}
		}
	}
}
