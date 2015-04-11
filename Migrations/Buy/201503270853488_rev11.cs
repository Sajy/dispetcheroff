namespace mvc2.Migrations.Buy
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.buy", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.buy", "Date");
        }
    }
}
