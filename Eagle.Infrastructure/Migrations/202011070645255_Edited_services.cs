namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Edited_services : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Services", "Title", c => c.String(nullable: false, maxLength: 600));
            DropColumn("dbo.Services", "Thumbnail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "Thumbnail", c => c.String());
            AlterColumn("dbo.Services", "Title", c => c.String(maxLength: 600));
        }
    }
}
