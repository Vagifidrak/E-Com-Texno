namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userRegisteredOn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "RegisteredOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "RegisteredOn");
        }
    }
}
