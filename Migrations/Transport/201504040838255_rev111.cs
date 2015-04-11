namespace mvc2.Migrations.Transport
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev111 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.transport", "AutoModelId", "dbo.automodel");
            DropForeignKey("dbo.transport", "AutoTypeId", "dbo.autotype");
            DropIndex("dbo.transport", new[] { "AutoModelId" });
            DropIndex("dbo.transport", new[] { "AutoTypeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.transport", "AutoTypeId");
            CreateIndex("dbo.transport", "AutoModelId");
            AddForeignKey("dbo.transport", "AutoTypeId", "dbo.autotype", "Id", cascadeDelete: true);
            AddForeignKey("dbo.transport", "AutoModelId", "dbo.automodel", "Id", cascadeDelete: true);
        }
    }
}
