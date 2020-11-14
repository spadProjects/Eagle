namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edited_static_content : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StaticContentDetails", "ShortDescription", c => c.String());
            AlterColumn("dbo.StaticContentDetails", "Identifier", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.StaticContentDetails", "Title", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.StaticContentTypes", "Identifier", c => c.String(nullable: false, maxLength: 600));
            AlterColumn("dbo.StaticContentTypes", "Name", c => c.String(nullable: false, maxLength: 600));
            DropColumn("dbo.StaticContentDetails", "FieldDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StaticContentDetails", "FieldDescription", c => c.String());
            AlterColumn("dbo.StaticContentTypes", "Name", c => c.String(maxLength: 600));
            AlterColumn("dbo.StaticContentTypes", "Identifier", c => c.String(maxLength: 600));
            AlterColumn("dbo.StaticContentDetails", "Title", c => c.String(maxLength: 600));
            AlterColumn("dbo.StaticContentDetails", "Identifier", c => c.String(maxLength: 600));
            DropColumn("dbo.StaticContentDetails", "ShortDescription");
        }
    }
}
