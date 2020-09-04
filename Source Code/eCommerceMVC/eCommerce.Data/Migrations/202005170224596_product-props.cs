namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productprops : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Discount", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Products", "Cost", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Products", "SKU", c => c.String());
            AddColumn("dbo.Products", "Tags", c => c.String());
            AddColumn("dbo.Products", "Barcode", c => c.String());
            AddColumn("dbo.Products", "Supplier", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Supplier");
            DropColumn("dbo.Products", "Barcode");
            DropColumn("dbo.Products", "Tags");
            DropColumn("dbo.Products", "SKU");
            DropColumn("dbo.Products", "Cost");
            DropColumn("dbo.Products", "Discount");
        }
    }
}
