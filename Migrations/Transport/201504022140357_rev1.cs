namespace mvc2.Migrations.Transport
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.automodel",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.autonumber",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumberText = c.String(),
                        TransportId = c.Int(nullable: false),
                        NumAutoModelId = c.Int(nullable: false),
                        NumAutoTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.transport", t => t.TransportId, cascadeDelete: true)
                .Index(t => t.TransportId);
            
            CreateTable(
                "dbo.transport",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AutoModelId = c.Int(nullable: false),
                        AutoTypeId = c.Int(nullable: false),
                        AutosQuantity = c.Int(nullable: false),
                        Tel = c.String(),
                        Email = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.automodel", t => t.AutoModelId, cascadeDelete: true)
                .ForeignKey("dbo.autotype", t => t.AutoTypeId, cascadeDelete: true)
                .Index(t => t.AutoModelId)
                .Index(t => t.AutoTypeId);
            
            CreateTable(
                "dbo.autotype",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
           
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.transport", "AutoTypeId", "dbo.autotype");
            DropForeignKey("dbo.autonumber", "TransportId", "dbo.transport");
            DropForeignKey("dbo.transport", "AutoModelId", "dbo.automodel");
            DropIndex("dbo.transport", new[] { "AutoTypeId" });
            DropIndex("dbo.autonumber", new[] { "TransportId" });
            DropIndex("dbo.transport", new[] { "AutoModelId" });
      
            DropTable("dbo.autotype");
            DropTable("dbo.transport");
            DropTable("dbo.autonumber");
            DropTable("dbo.automodel");
        }
    }
}
