/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 22:38
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace mvc2.Models.Grids
{
	/// <summary>
	/// Description of ContractGridModel.
	/// </summary>
	public class ContractGridModel
	{
		public int Id { get; set; }
		
		[Display(Name = "Текст контракта")]
		public string Text { get; set; }
	}
}
