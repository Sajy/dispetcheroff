namespace mvc2.Migrations.Buy
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev14 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.contract",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.contract");
        }
    }
}
