namespace mvc2.Migrations.Buy
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.buy",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        ProductTypeId = c.Int(nullable: false),
                        QualityId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        MinAmount = c.Double(nullable: false),
                        Tel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.buy");
        }
    }
}
