namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class commentLanguage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "LanguageID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "LanguageID");
        }
    }
}
