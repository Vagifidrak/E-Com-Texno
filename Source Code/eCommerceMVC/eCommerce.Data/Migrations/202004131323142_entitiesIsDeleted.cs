namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class entitiesIsDeleted : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Categories", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.CategoryRecords", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.CategoryRecords", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductPictures", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductPictures", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pictures", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pictures", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductRecords", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductRecords", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductSpecifications", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.ProductSpecifications", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Comments", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Comments", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Languages", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Languages", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderHistories", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderHistories", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Orders", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderItems", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.OrderItems", "IsDeleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.Promoes", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Promoes", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Promoes", "IsDeleted");
            DropColumn("dbo.Promoes", "IsActive");
            DropColumn("dbo.OrderItems", "IsDeleted");
            DropColumn("dbo.OrderItems", "IsActive");
            DropColumn("dbo.Orders", "IsDeleted");
            DropColumn("dbo.Orders", "IsActive");
            DropColumn("dbo.OrderHistories", "IsDeleted");
            DropColumn("dbo.OrderHistories", "IsActive");
            DropColumn("dbo.Languages", "IsDeleted");
            DropColumn("dbo.Languages", "IsActive");
            DropColumn("dbo.Comments", "IsDeleted");
            DropColumn("dbo.Comments", "IsActive");
            DropColumn("dbo.ProductSpecifications", "IsDeleted");
            DropColumn("dbo.ProductSpecifications", "IsActive");
            DropColumn("dbo.ProductRecords", "IsDeleted");
            DropColumn("dbo.ProductRecords", "IsActive");
            DropColumn("dbo.Pictures", "IsDeleted");
            DropColumn("dbo.Pictures", "IsActive");
            DropColumn("dbo.ProductPictures", "IsDeleted");
            DropColumn("dbo.ProductPictures", "IsActive");
            DropColumn("dbo.Products", "IsDeleted");
            DropColumn("dbo.Products", "IsActive");
            DropColumn("dbo.CategoryRecords", "IsDeleted");
            DropColumn("dbo.CategoryRecords", "IsActive");
            DropColumn("dbo.Categories", "IsDeleted");
            DropColumn("dbo.Categories", "IsActive");
        }
    }
}
