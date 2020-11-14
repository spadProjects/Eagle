namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedArticleValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Title", c => c.String(nullable: false, maxLength: 600));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "Title", c => c.String(maxLength: 600));
        }
    }
}
