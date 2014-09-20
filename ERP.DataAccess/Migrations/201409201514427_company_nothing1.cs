namespace ERP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class company_nothing1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "TinNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "TinNumber");
        }
    }
}
