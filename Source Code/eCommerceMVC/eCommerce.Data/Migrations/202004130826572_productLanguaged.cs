namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productLanguaged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductSpecifications", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductSpecifications", new[] { "ProductID" });
            CreateTable(
                "dbo.ProductRecords",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        LanguageID = c.Int(nullable: false),
                        Name = c.String(),
                        Summary = c.String(),
                        Description = c.String(),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            AddColumn("dbo.ProductSpecifications", "ProductRecordID", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductSpecifications", "ProductRecordID");
            AddForeignKey("dbo.ProductSpecifications", "ProductRecordID", "dbo.ProductRecords", "ID", cascadeDelete: true);
            DropColumn("dbo.Products", "Name");
            DropColumn("dbo.Products", "Summary");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.ProductSpecifications", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ProductSpecifications", "ProductID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Summary", c => c.String());
            AddColumn("dbo.Products", "Name", c => c.String());
            DropForeignKey("dbo.ProductSpecifications", "ProductRecordID", "dbo.ProductRecords");
            DropForeignKey("dbo.ProductRecords", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductSpecifications", new[] { "ProductRecordID" });
            DropIndex("dbo.ProductRecords", new[] { "ProductID" });
            DropColumn("dbo.ProductSpecifications", "ProductRecordID");
            DropTable("dbo.ProductRecords");
            CreateIndex("dbo.ProductSpecifications", "ProductID");
            AddForeignKey("dbo.ProductSpecifications", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
        }
    }
}
