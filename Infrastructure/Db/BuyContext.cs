/*
 * Создано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 27.03.2015
 * Время: 9:27
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
	/// Description of BuyContext.
	/// </summary>
	public class BuyContext: DbContext
	{
		public DbSet<Buy> Buys { get; set; }
		public DbSet<Contract> Contracts { get; set; }
		public DbSet<Product> Products { get; set; }
	    public DbSet<Department> Departments { get; set; }
	    public DbSet<HoldArea> HoldAreas { get; set; }
	    public DbSet<ProductType> ProductTypes { get; set; }
	    public DbSet<Quality> Qualities { get; set; }
	    public DbSet<District> Districts { get; set; }
	}
}
