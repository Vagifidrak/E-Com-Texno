namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class orderguestbool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "IsGuestOrder", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "IsGuestOrder", c => c.Int(nullable: false));
        }
    }
}
