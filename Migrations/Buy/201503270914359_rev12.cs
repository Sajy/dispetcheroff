namespace mvc2.Migrations.Buy
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.buy", "HoldAreaId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.buy", "HoldAreaId");
        }
    }
}
