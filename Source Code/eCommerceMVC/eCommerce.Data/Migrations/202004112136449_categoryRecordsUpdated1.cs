namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryRecordsUpdated1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "CategoryRecordID", "dbo.CategoryRecords");
            DropIndex("dbo.Categories", new[] { "CategoryRecordID" });
            AddColumn("dbo.CategoryRecords", "CategoryID", c => c.Int(nullable: false));
            AddColumn("dbo.CategoryRecords", "LanguageID", c => c.Int(nullable: false));
            AddColumn("dbo.CategoryRecords", "Name", c => c.String());
            AddColumn("dbo.CategoryRecords", "Summary", c => c.String());
            AddColumn("dbo.CategoryRecords", "Description", c => c.String());
            CreateIndex("dbo.CategoryRecords", "CategoryID");
            AddForeignKey("dbo.CategoryRecords", "CategoryID", "dbo.Categories", "ID", cascadeDelete: true);
            DropColumn("dbo.Categories", "CategoryRecordID");
            DropColumn("dbo.Categories", "LanguageID");
            DropColumn("dbo.Categories", "Name");
            DropColumn("dbo.Categories", "Summary");
            DropColumn("dbo.Categories", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Description", c => c.String());
            AddColumn("dbo.Categories", "Summary", c => c.String());
            AddColumn("dbo.Categories", "Name", c => c.String());
            AddColumn("dbo.Categories", "LanguageID", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "CategoryRecordID", c => c.Int());
            DropForeignKey("dbo.CategoryRecords", "CategoryID", "dbo.Categories");
            DropIndex("dbo.CategoryRecords", new[] { "CategoryID" });
            DropColumn("dbo.CategoryRecords", "Description");
            DropColumn("dbo.CategoryRecords", "Summary");
            DropColumn("dbo.CategoryRecords", "Name");
            DropColumn("dbo.CategoryRecords", "LanguageID");
            DropColumn("dbo.CategoryRecords", "CategoryID");
            CreateIndex("dbo.Categories", "CategoryRecordID");
            AddForeignKey("dbo.Categories", "CategoryRecordID", "dbo.CategoryRecords", "ID");
        }
    }
}
