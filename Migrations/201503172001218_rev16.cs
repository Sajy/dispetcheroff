namespace mvc2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.holdarea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.producttype",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.quality",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.sell", "HoldAreaId");
            CreateIndex("dbo.sell", "ProductTypeId");
            CreateIndex("dbo.sell", "QualityId");
            AddForeignKey("dbo.sell", "HoldAreaId", "dbo.holdarea", "Id", cascadeDelete: true);
            AddForeignKey("dbo.sell", "ProductTypeId", "dbo.producttype", "Id", cascadeDelete: true);
            AddForeignKey("dbo.sell", "QualityId", "dbo.quality", "Id", cascadeDelete: true);
            DropColumn("dbo.sell", "DistrictId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.sell", "DistrictId", c => c.Int(nullable: false));
            DropForeignKey("dbo.sell", "QualityId", "dbo.quality");
            DropForeignKey("dbo.sell", "ProductTypeId", "dbo.producttype");
            DropForeignKey("dbo.sell", "HoldAreaId", "dbo.holdarea");
            DropIndex("dbo.sell", new[] { "QualityId" });
            DropIndex("dbo.sell", new[] { "ProductTypeId" });
            DropIndex("dbo.sell", new[] { "HoldAreaId" });
            DropTable("dbo.quality");
            DropTable("dbo.producttype");
            DropTable("dbo.holdarea");
        }
    }
}
