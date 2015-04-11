/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 12.03.2015
 * Время: 17:42
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.ComponentModel.DataAnnotations;

namespace mvc2.Models
{
	/// <summary>
	/// Description of LoginViewModel.
	/// </summary>
	public class LoginViewModel
	{
		
		
		[Required(ErrorMessage="Требуется поле Имейл")][Display(Name = "Имейл")]
		public string UserName { get; set; }
		[Required(ErrorMessage="Требуется поле Пароль")][Display(Name = "Пароль")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
		
	
	}
}
