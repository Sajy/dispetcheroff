namespace mvc2.Migrations.Transport
{
    using System;
	using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using System.Web.UI.WebControls;
	using mvc2.Models.References;
	using mvc2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<mvc2.Infrastructure.Db.TransportContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Transport";
            ContextKey = "mvc2.Infrastructure.Db.TransportContext";
        }

        protected override void Seed(mvc2.Infrastructure.Db.TransportContext context)
        {
        	fillTransport(context);
        }
        
        	private void fillTransport(mvc2.Infrastructure.Db.TransportContext context){
			
			var automodel1 = new AutoModel(){Id=1,Name="Ман" };
			var automodel2 = new AutoModel(){Id=2,Name="Даф" };
			var automodel3 = new AutoModel(){Id=3,Name="Вольво" };
			var automodel4 = new AutoModel(){Id=4,Name="Мерседес" };
			var automodel5 = new AutoModel(){Id=5,Name="Маз" };
			var automodel6 = new AutoModel(){Id=6,Name="Камаз" };
			var automodels = new List<AutoModel> {automodel1,automodel2,automodel3,automodel4,automodel5,automodel6};
			
			
			var autotype1=new AutoType(){Id=1,Name="Cцепка"};
			var autotype2=new AutoType(){Id=2,Name="Полуприцеп"};
			var autotype3=new AutoType(){Id=3,Name="Cамосвал"};
			var autotypes = new List<AutoType> {autotype1,autotype2,autotype3};
			
			
			
			
			var autonumber1 = new AutoNumber {Id=1, NumberText="ВЕ3456АЕ", TransportId=1, NumAutoModelId=automodel1.Id,NumAutoTypeId=autotype1.Id };
			var autonumber2 = new AutoNumber {Id=2, NumberText="ВЕ1234АЕ", TransportId=1, NumAutoModelId=automodel1.Id,NumAutoTypeId=autotype2.Id };
			var autonumber3 = new AutoNumber {Id=3, NumberText="ВЕ2345АЕ", TransportId=2, NumAutoModelId=automodel2.Id,NumAutoTypeId=autotype3.Id };
			var autonumber4 = new AutoNumber {Id=4, NumberText="ВЕ5678АЕ", TransportId=3, NumAutoModelId=automodel3.Id,NumAutoTypeId=autotype1.Id };
			var autonumber5 = new AutoNumber {Id=5, NumberText="ВЕ7896АЕ", TransportId=4, NumAutoModelId=automodel1.Id,NumAutoTypeId=autotype1.Id };
			var autonumbers= new List<AutoNumber> {autonumber1,autonumber2,autonumber3,autonumber4,autonumber5};
			
			
			
			var transports = new List<Transport> {
				new Transport{Id=1, AutoModelId=automodel1.Id, AutoTypeId=autotype1.Id, Email="email1@mail.ru", 
					Tel="(0512) 34-77-22", Date=new DateTime(2014,11,14), AutosQuantity=2},
				new Transport{Id=2, AutoModelId=automodel1.Id, AutoTypeId=autotype2.Id, Email="email2@mail.ru",  
					Tel="(0512) 34-71-44",  Date=new DateTime(2014,10,13), AutosQuantity=1},
				new Transport{Id=3, AutoModelId=automodel2.Id, AutoTypeId=autotype3.Id, Email="email3@mail.ru",   
					Tel="(0512) 34-22-22",  Date=new DateTime(2014,09,12), AutosQuantity=1},
				new Transport{Id=4, AutoModelId=automodel3.Id, AutoTypeId=autotype1.Id, Email="email4@mail.ru",  
					Tel="(0512) 34-71-11",  Date=new DateTime(2014,08,11), AutosQuantity=1}
			};
			
			
			
			
			automodels.ForEach(r => context.AutoModels.AddOrUpdate(r));
			autotypes.ForEach(r => context.AutoTypes.AddOrUpdate(r));
			autonumbers.ForEach(r => context.AutoNumbers.AddOrUpdate(r));
			transports.ForEach(r => context.Transports.AddOrUpdate(k=>k.Id,r));
			
			context.SaveChanges();
			
		}
    }
}
