namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categorypicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "PictureID", c => c.Int());
            CreateIndex("dbo.Categories", "PictureID");
            AddForeignKey("dbo.Categories", "PictureID", "dbo.Pictures", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "PictureID", "dbo.Pictures");
            DropIndex("dbo.Categories", new[] { "PictureID" });
            DropColumn("dbo.Categories", "PictureID");
        }
    }
}
