namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class languagePicture : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Languages", "PictureID", c => c.Int());
            CreateIndex("dbo.Languages", "PictureID");
            AddForeignKey("dbo.Languages", "PictureID", "dbo.Pictures", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Languages", "PictureID", "dbo.Pictures");
            DropIndex("dbo.Languages", new[] { "PictureID" });
            DropColumn("dbo.Languages", "PictureID");
        }
    }
}
