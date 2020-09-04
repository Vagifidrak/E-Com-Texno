namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderguest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "IsGuestOrder", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Orders", "IsGuestOrder");
        }
    }
}
