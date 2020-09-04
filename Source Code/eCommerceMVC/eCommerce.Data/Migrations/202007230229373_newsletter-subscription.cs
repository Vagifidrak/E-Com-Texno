namespace eCommerce.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newslettersubscription : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewsletterSubscriptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmailAddress = c.String(),
                        IsVerified = c.Boolean(nullable: false),
                        UserID = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        ModifiedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewsletterSubscriptions");
        }
    }
}
