namespace mvc2.Migrations
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using mvc2.Models.References;
	using mvc2.Models;
	internal sealed class Configuration : DbMigrationsConfiguration<mvc2.Infrastructure.Db.SellContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
			ContextKey = "mvc2.Infrastructure.Db.SellContext";
		}

		protected override void Seed(mvc2.Infrastructure.Db.SellContext context)
		{
			fillSell(context);
			
			
		}

		
		
		private void fillSell(mvc2.Infrastructure.Db.SellContext context){
			var product = new  Product(){Id=1,Name="Соя", Description="field"};
			var product2 = new  Product(){Id=2,Name="Рапс", Description="field"};
			var product3 = new  Product(){Id=3,Name="Пшеница", Description="field"};
			var products = new List<Product> {product,product2,product3};
			
			var quality1 = new  Quality(){Id=1,Text="Сор.: 7, Вл.: 8, Белок: 9"};
			var qualities = new List<Quality> {quality1};
			
			var productType1 = new  ProductType(){Id=1,Name="1 класс"};
			var productType2 = new  ProductType(){Id=2,Name="2 класс"};
			var productType3 = new  ProductType(){Id=3,Name="3 класс"};
			var productTypes=new List<ProductType>{productType1,productType2,productType3};
			
			var department1 = new  Department(){Id=1,Name="Николаевская"};
			var department2 = new  Department(){Id=2,Name="Киевская"};
			var department3 = new  Department(){Id=3,Name="Кировоградская"};
			var department4 = new  Department(){Id=4,Name="Одесская"};
			var department5 = new  Department(){Id=5,Name="Полтавская"};
			var department6 = new  Department(){Id=6,Name="Сумская"};
			var departments = new List<Department>{department1,department2,department3,department4,department5,department6};
			
			var holdArea1 = new  HoldArea(){Id=1,Name="На складе"};
			var holdArea2 = new  HoldArea(){Id=2,Name="На элеваторе"};
			var holdArea3 = new  HoldArea(){Id=3,Name="В поле"};
			var holdArea4 = new  HoldArea(){Id=4,Name="В хозяйстве"};
			var holdAreas=new List<HoldArea>{holdArea1,holdArea2,holdArea3,holdArea4};
			
			var district1 = new  District(){ Id=1, DepartmentId=department1.Id, Name="Баштанский"};
			var district2 = new  District(){ Id=2,DepartmentId=department1.Id, Name="Братский"};
			var district3 = new  District(){ Id=3,DepartmentId=department1.Id, Name="Кривоозерский"};
			var district4 = new  District(){ Id=4,DepartmentId=department2.Id, Name="Броварский"};
			var district5 = new  District(){ Id=5,DepartmentId=department3.Id, Name="Долинский"};
			var district6 = new  District(){ Id=6,DepartmentId=department3.Id, Name="Знаменский"};
			var district7 = new  District(){ Id=7,DepartmentId=department1.Id, Name="Арбузинский"};
			var district8 = new  District(){ Id=8,DepartmentId=department1.Id, Name="Новобугский"};
			var districs = new List<District> {district1,district2,district3,district4,district5,district6,district7, district8};
			
			
			var sells = new List<Sell>{
				new Sell{Id=1,Price = 10,ProductId=product.Id, HoldAreaId=holdArea1.Id, Tel="(055) 222-88-11", City="Николаев", Amount=10,
					ProductTypeId=productType1.Id,QualityId=quality1.Id,DistrictId=district1.Id, Date=new DateTime(2014,12,13)},
				new Sell{Id=2,Price = 20,ProductId=product2.Id, HoldAreaId=holdArea2.Id, Tel="(056) 22-44-22", City="Николаев", Amount=10,
					ProductTypeId=productType2.Id,QualityId=quality1.Id,DistrictId=district2.Id, Date=new DateTime(2014,11,16)},
				new Sell{Id=3, Price = 30,ProductId=product2.Id, HoldAreaId=holdArea3.Id, Tel="(057) 224-66-33", City="Николаев",Amount=10,
					ProductTypeId=productType3.Id,QualityId=quality1.Id,DistrictId=district3.Id, Date=new DateTime(2014,06,11)},
				new Sell{Id=4, Price = 40,ProductId=product3.Id, HoldAreaId=holdArea4.Id, Tel="(058) 334-77-44", City="Николаев", Amount=10,
					ProductTypeId=productType3.Id,QualityId=quality1.Id,DistrictId=district4.Id, Date=new DateTime(2015,01,21)}
			};
			
			products.ForEach(r => context.Products.AddOrUpdate(r));
			qualities.ForEach(r => context.Qualities.AddOrUpdate(r));
			productTypes.ForEach(r => context.ProductTypes.AddOrUpdate(r));
			departments.ForEach(r => context.Departments.AddOrUpdate(r));
			holdAreas.ForEach(r => context.HoldAreas.AddOrUpdate(r));
			districs.ForEach(r => context.Districts.AddOrUpdate(k => k.Id,r));
			sells.ForEach(r => context.Sells.AddOrUpdate(k=>k.Id,r));
			context.SaveChanges();
		}
	}
}
