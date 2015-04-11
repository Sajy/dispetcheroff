/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 12.03.2015
 * Время: 16:21
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace mvc2.Abstract
{
	/// <summary>
	/// Description of IAuthProvider.
	/// </summary>
	public interface IAuthProvider
	{
		bool Authenticate(string username, string password);
	}
}
