namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class languageresource : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.LanguageResources");
            AddColumn("dbo.LanguageResources", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.LanguageResources", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.LanguageResources", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.LanguageResources", "ModifiedOn", c => c.DateTime());
            AlterColumn("dbo.LanguageResources", "Key", c => c.String());
            AddPrimaryKey("dbo.LanguageResources", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.LanguageResources");
            AlterColumn("dbo.LanguageResources", "Key", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.LanguageResources", "ModifiedOn");
            DropColumn("dbo.LanguageResources", "IsDeleted");
            DropColumn("dbo.LanguageResources", "IsActive");
            DropColumn("dbo.LanguageResources", "ID");
            AddPrimaryKey("dbo.LanguageResources", "Key");
        }
    }
}
