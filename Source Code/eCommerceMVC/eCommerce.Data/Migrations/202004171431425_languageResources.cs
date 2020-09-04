namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class languageResources : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LanguageResources",
                c => new
                    {
                        Key = c.String(nullable: false, maxLength: 128),
                        LanguageID = c.Int(nullable: false),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LanguageResources");
        }
    }
}
