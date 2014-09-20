namespace ERP.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class company_address1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "address1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "address1");
        }
    }
}
