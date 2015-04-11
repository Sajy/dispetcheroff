/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 23:20
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Data.Entity;
using mvc2.Models;

namespace mvc2.Infrastructure.Db
{
	/// <summary>
	/// Description of ContractContext.
	/// </summary>
	public class ContractContext: DbContext
	{
		public DbSet<Contract> Contracts { get; set; }
	}
}
