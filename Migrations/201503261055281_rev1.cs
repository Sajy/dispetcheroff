namespace mvc2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.district",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DepartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.department", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.holdarea",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
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
            
            CreateTable(
                "dbo.sell",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                        DistrictId = c.Int(nullable: false),
                        HoldAreaId = c.Int(nullable: false),
                        QualityId = c.Int(nullable: false),
                        Price = c.Double(nullable: false),
                        Amount = c.Double(nullable: false),
                        City = c.String(),
                        Tel = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.district", t => t.DistrictId, cascadeDelete: true)
                .ForeignKey("dbo.holdarea", t => t.HoldAreaId, cascadeDelete: true)
                .ForeignKey("dbo.product", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.producttype", t => t.ProductTypeId, cascadeDelete: true)
                .ForeignKey("dbo.quality", t => t.QualityId, cascadeDelete: true)
                .Index(t => t.DistrictId)
                .Index(t => t.HoldAreaId)
                .Index(t => t.ProductId)
                .Index(t => t.ProductTypeId)
                .Index(t => t.QualityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.sell", "QualityId", "dbo.quality");
            DropForeignKey("dbo.sell", "ProductTypeId", "dbo.producttype");
            DropForeignKey("dbo.sell", "ProductId", "dbo.product");
            DropForeignKey("dbo.sell", "HoldAreaId", "dbo.holdarea");
            DropForeignKey("dbo.sell", "DistrictId", "dbo.district");
            DropForeignKey("dbo.district", "DepartmentId", "dbo.department");
            DropIndex("dbo.sell", new[] { "QualityId" });
            DropIndex("dbo.sell", new[] { "ProductTypeId" });
            DropIndex("dbo.sell", new[] { "ProductId" });
            DropIndex("dbo.sell", new[] { "HoldAreaId" });
            DropIndex("dbo.sell", new[] { "DistrictId" });
            DropIndex("dbo.district", new[] { "DepartmentId" });
            DropTable("dbo.sell");
            DropTable("dbo.quality");
            DropTable("dbo.producttype");
            DropTable("dbo.product");
            DropTable("dbo.holdarea");
            DropTable("dbo.district");
            DropTable("dbo.department");
        }
    }
}
