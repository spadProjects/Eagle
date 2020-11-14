namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedtestimonial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Testimonials", "Title", c => c.String(nullable: false));
            AddColumn("dbo.Testimonials", "Description", c => c.String(nullable: false));
            DropColumn("dbo.Testimonials", "Speaker");
            DropColumn("dbo.Testimonials", "Message");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Testimonials", "Message", c => c.String());
            AddColumn("dbo.Testimonials", "Speaker", c => c.String());
            DropColumn("dbo.Testimonials", "Description");
            DropColumn("dbo.Testimonials", "Title");
        }
    }
}
