/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 13.03.2015
 * Время: 12:15
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Data.Entity;
using mvc2.Models;

namespace mvc2.Infrastructure.Db

{
	/// <summary>
	/// Description of DispDataContext.
	/// </summary>
	public class DispDataContext: DbContext
	{
		public DbSet<Auction> Auctions { get; set; }
		
		public DispDataContext()
		{
			
		}
	}
}
