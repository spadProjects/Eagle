namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedtestimonial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Testimonials", "Rate", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Testimonials", "Rate", c => c.Int(nullable: false));
        }
    }
}
