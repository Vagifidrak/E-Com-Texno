namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class languageIcon : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Languages", "PictureID", "dbo.Pictures");
            DropIndex("dbo.Languages", new[] { "PictureID" });
            AddColumn("dbo.Languages", "IconCode", c => c.String());
            DropColumn("dbo.Languages", "PictureID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Languages", "PictureID", c => c.Int());
            DropColumn("dbo.Languages", "IconCode");
            CreateIndex("dbo.Languages", "PictureID");
            AddForeignKey("dbo.Languages", "PictureID", "dbo.Pictures", "ID");
        }
    }
}
