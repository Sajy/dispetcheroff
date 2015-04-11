/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 26.03.2015
 * Время: 11:23
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Data.Entity;
using mvc2.Models;
using mvc2.Models.References;

namespace mvc2.Infrastructure.Db
{
	/// <summary>
	/// Description of TransportContext.
	/// </summary>
	public class TransportContext: DbContext
	{
		public DbSet<Transport> Transports { get; set; }
		public DbSet<AutoModel> AutoModels { get; set; }
	    public DbSet<AutoType> AutoTypes { get; set; }
	    public DbSet<AutoNumber> AutoNumbers { get; set; }
		public DbSet<Contract> Contracts { get; set; }
	
	}
}
