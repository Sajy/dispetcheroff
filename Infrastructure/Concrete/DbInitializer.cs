/*
 * Сделано в SharpDevelop.
 * Пользователь: Администратор
 * Дата: 14.03.2015
 * Время: 12:37
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;
using mvc2.Infrastructure.Db;
using System.Data.Entity;
using mvc2.Models;
using mvc2.Models.References;
using System.Collections.Generic;

namespace mvc2.Infrastructure.Concrete
{
	/// <summary>
	/// Description of DbInitializer.
	/// </summary>
	public class DbInitializer: CreateDatabaseIfNotExists<SellContext>
	{
		
		
		protected override void Seed(SellContext context)
		{
//			Product product = new  Product(){Id=1,Name="Соя"};
//			Product product2 = new  Product(){Id=2,Name="Рапс"};
//			Product product3 = new  Product(){Id=3,Name="Пшеница"};
//			
//			ProductType productType1 = new  ProductType(){Id=1,Name="1 класс"};
//			ProductType productType2 = new  ProductType(){Id=2,Name="2 класс"};
//			ProductType productType3 = new  ProductType(){Id=3,Name="3 класс"};
//			
//			Department department1 = new  Department(){Id=1,Name="Николаевская"};
//			Department department2 = new  Department(){Id=2,Name="Киевская"};
//			Department department3 = new  Department(){Id=3,Name="Кировоградская"};
//			
//			District district1 = new  District(){Id=1, Department=department1, Name="Баштанский"};
//			District district2 = new  District(){Id=2, Department=department1, Name="Братский"};
//			District district3 = new  District(){Id=3, Department=department1, Name="Кривоозерский"};
//		    District district4 = new  District(){Id=4, Department=department2, Name="Броварский"};
//			District district5 = new  District(){Id=5, Department=department3, Name="Долинский"};
//			District district6 = new  District(){Id=6, Department=department3, Name="Знаменский"};
//			
//			HoldArea holdArea1 = new  HoldArea(){Id=1,Name="На складе"};
//			HoldArea holdArea2 = new  HoldArea(){Id=2,Name="На элеваторе"};
//			HoldArea holdArea3 = new  HoldArea(){Id=3,Name="В поле"};
//			HoldArea holdArea4 = new  HoldArea(){Id=4,Name="В хозяйстве"};
//			
//			Quality quality1 = new  Quality(){Id=1,Text="Сор.: 7, Вл.: 8, Белок: 9"};
//			
//			
//			var sells = new List<Sell>{
//				new Sell{Price = 10,Product=product},
//				new Sell{Price = 20,Product=product2},
//				new Sell{Price = 30,Product=product2},
//				new Sell{Price = 40,Product=product3}
//			};
//			
//			sells.ForEach(r => context.Sells.Add(r));
//			context.SaveChanges();
		}
	}
}
