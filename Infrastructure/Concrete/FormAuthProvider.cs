/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 12.03.2015
 * Время: 16:23
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Web.Security;

namespace mvc2.Infrastructure.Concrete
{
	/// <summary>
	/// Description of FormAuthProvider.
	/// </summary>
	public class FormAuthProvider: Abstract.IAuthProvider
	{
		
		
		public bool Authenticate(string username, string password)
		{
			
			bool result=true;
//				= FormsAuthentication.Authenticate(username, password);
//			if (result) {
//				FormsAuthentication.SetAuthCookie(username, false);
//			}
			return result;
		}
	}
}
