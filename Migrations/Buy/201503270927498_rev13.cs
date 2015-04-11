namespace mvc2.Migrations.Buy
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev13 : DbMigration
    {
        public override void Up()
        {
            
            
            CreateIndex("dbo.buy", "HoldAreaId");
            CreateIndex("dbo.buy", "ProductId");
            CreateIndex("dbo.buy", "ProductTypeId");
            CreateIndex("dbo.buy", "QualityId");
            AddForeignKey("dbo.buy", "HoldAreaId", "dbo.holdarea", "Id", cascadeDelete: true);
            AddForeignKey("dbo.buy", "ProductId", "dbo.product", "Id", cascadeDelete: true);
            AddForeignKey("dbo.buy", "ProductTypeId", "dbo.producttype", "Id", cascadeDelete: true);
            AddForeignKey("dbo.buy", "QualityId", "dbo.quality", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.buy", "QualityId", "dbo.quality");
            DropForeignKey("dbo.buy", "ProductTypeId", "dbo.producttype");
            DropForeignKey("dbo.buy", "ProductId", "dbo.product");
            DropForeignKey("dbo.buy", "HoldAreaId", "dbo.holdarea");
            DropIndex("dbo.buy", new[] { "QualityId" });
            DropIndex("dbo.buy", new[] { "ProductTypeId" });
            DropIndex("dbo.buy", new[] { "ProductId" });
            DropIndex("dbo.buy", new[] { "HoldAreaId" });
           
        }
    }
}
