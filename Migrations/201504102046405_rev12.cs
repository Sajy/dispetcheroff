namespace mvc2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.sell", "Tel", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.sell", "Tel", c => c.String());
        }
    }
}
