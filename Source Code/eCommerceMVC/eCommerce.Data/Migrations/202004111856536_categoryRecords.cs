namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryRecords : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryRecords",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LanguageID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryRecords", "CategoryID", "dbo.Categories");
            DropIndex("dbo.CategoryRecords", new[] { "CategoryID" });
            DropTable("dbo.CategoryRecords");
        }
    }
}
