namespace mvc2.Migrations.Transport
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.transport", "Tel", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.transport", "Tel", c => c.String());
        }
    }
}
