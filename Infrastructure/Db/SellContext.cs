/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 13.03.2015
 * Время: 23:59
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using System.Data.Entity;
using mvc2.Models.References;
using mvc2.Models;
using System.Collections.Generic;

namespace mvc2.Infrastructure.Db
{
	/// <summary>
	/// Description of SellContext.
	/// </summary>
	public class SellContext: DbContext
	{
	
		public DbSet<Sell> Sells { get; set; }
		public DbSet<Product> Products { get; set; }
	    public DbSet<Department> Departments { get; set; }
	    public DbSet<HoldArea> HoldAreas { get; set; }
	    public DbSet<ProductType> ProductTypes { get; set; }
	    public DbSet<Quality> Qualities { get; set; }
	    public DbSet<District> Districts { get; set; }
		public DbSet<Contract> Contracts { get; set; }

	}
	
	
}
