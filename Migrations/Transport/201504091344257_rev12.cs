namespace mvc2.Migrations.Transport
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.transport", "Email", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.transport", "Email", c => c.String());
        }
    }
}
