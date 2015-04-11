namespace mvc2.Migrations.Buy
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;
	using mvc2.Models.References;
using mvc2.Models;

	internal sealed class Configuration : DbMigrationsConfiguration<mvc2.Infrastructure.Db.BuyContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
			MigrationsDirectory = @"Migrations\Buy";
		}

		protected override void Seed(mvc2.Infrastructure.Db.BuyContext context)
		{
			fillSell(context);
		}
        
        
		private void fillSell(mvc2.Infrastructure.Db.BuyContext context)
		{
			var contracts = new List<Contract> {
				new Contract{Id=1,Text="Купим 160т гороха желтого от производителя, цена в Николаеве 3850 б/н, возможен самовывоз"},
				new Contract{Id=2,Text="Закупаем пшеницу фуражную (белок от 10,5%) в неограниченых количествах, цена в Николаеве 2170/2140, возможен самовывоз с хозяйства/склада"},
				new Contract{Id=3,Text="Купим 3 000т кукурузы, цена в Николаеве 1825/1780, возможен самовывоз с хозяйства/склада."},
				new Contract{Id=4,Text="До 16.09.2014 года принимаем заявки от производителей на поставку люпина объемом до 3 000т, минимальная партия поставки 200т. Место выгрузки - Николаев, возможен самовывоз. Предложения по телефону (050) 000-00-00 или e-mail"},
				new Contract{Id=5,Text="Закупаем 2,500т Рапса, минимальная партия 100т, Цена в Голованевске(Кировоградской области) 4900 грн/т б/н. Возможен самомвывоз с хозяйства/склада/элеватора"}
			};
			
			var buys = new List<Buy>{
				new Buy{Id=1,ProductId=1, HoldAreaId=1,  QualityId=1,ProductTypeId=1, Tel="(058) 334-77-55", DistrictId=15,
					Amount=10, MinAmount=10, Date=new DateTime(2015,01,21),Price=100},
				new Buy{Id=2,ProductId=2, HoldAreaId=2, QualityId=1,ProductTypeId=2, Tel="(058) 334-77-66",  DistrictId=20,
					Amount=20, MinAmount=20, Date=new DateTime(2015,01,22),Price=200},
				new Buy{Id=3,ProductId=3,HoldAreaId=3, QualityId=1,ProductTypeId=3, Tel="(058) 334-77-77",  DistrictId=32,
					Amount=30, MinAmount=30, Date=new DateTime(2015,01,23),Price=300},
				new Buy{Id=4,ProductId=3,HoldAreaId=4, QualityId=1,ProductTypeId=3, Tel="(058) 334-77-88",  DistrictId=43,
					Amount=40, MinAmount=40, Date=new DateTime(2015,01,25),Price=400}
			
			};

			contracts.ForEach(r => context.Contracts.AddOrUpdate(k=>k.Id,r));
			buys.ForEach(r => context.Buys.AddOrUpdate(k=>k.Id,r));
			context.SaveChanges();
		}
	}
}
