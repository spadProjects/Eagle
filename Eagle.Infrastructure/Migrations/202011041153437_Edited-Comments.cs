namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedComments : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ArticleComments", "Name", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.ArticleComments", "Email", c => c.String(nullable: false, maxLength: 400));
            AlterColumn("dbo.ArticleComments", "Message", c => c.String(nullable: false, maxLength: 800));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ArticleComments", "Message", c => c.String(maxLength: 800));
            AlterColumn("dbo.ArticleComments", "Email", c => c.String(maxLength: 400));
            AlterColumn("dbo.ArticleComments", "Name", c => c.String(maxLength: 300));
        }
    }
}
