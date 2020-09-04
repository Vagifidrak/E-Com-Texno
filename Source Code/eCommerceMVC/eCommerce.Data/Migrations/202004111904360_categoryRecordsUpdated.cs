namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryRecordsUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CategoryRecords", "CategoryID", "dbo.Categories");
            DropIndex("dbo.CategoryRecords", new[] { "CategoryID" });
            AddColumn("dbo.Categories", "CategoryRecordID", c => c.Int());
            AddColumn("dbo.Categories", "LanguageID", c => c.Int(nullable: false));
            DropColumn("dbo.CategoryRecords", "LanguageID");
            DropColumn("dbo.CategoryRecords", "CategoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CategoryRecords", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.CategoryRecords", "LanguageID", c => c.Int(nullable: false));
            DropColumn("dbo.Categories", "LanguageID");
            DropColumn("dbo.Categories", "CategoryRecordID");
            CreateIndex("dbo.CategoryRecords", "CategoryID");
            AddForeignKey("dbo.CategoryRecords", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
        }
    }
}
