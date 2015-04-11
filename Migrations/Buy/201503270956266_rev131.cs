namespace mvc2.Migrations.Buy
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rev131 : DbMigration
    {
        public override void Up()
        {
            
            
            AddColumn("dbo.buy", "DistrictId", c => c.Int(nullable: false));
           
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.buy", "DistrictId", "dbo.district");
            
          
       
           
        
        }
    }
}
