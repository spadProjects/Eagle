namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedheadline : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ArticleHeadLines", "Title", c => c.String(nullable: false, maxLength: 700));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ArticleHeadLines", "Title", c => c.String(maxLength: 700));
        }
    }
}
