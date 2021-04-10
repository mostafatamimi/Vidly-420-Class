namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotateToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String());
        }
    }
}
