namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class something : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Categories", "CategoryRecordID");
            AddForeignKey("dbo.Categories", "CategoryRecordID", "dbo.CategoryRecords", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "CategoryRecordID", "dbo.CategoryRecords");
            DropIndex("dbo.Categories", new[] { "CategoryRecordID" });
        }
    }
}
