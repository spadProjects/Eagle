namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedfaq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Faqs", "Question", c => c.String(nullable: false));
            AlterColumn("dbo.Faqs", "Answer", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Faqs", "Answer", c => c.String());
            AlterColumn("dbo.Faqs", "Question", c => c.String());
        }
    }
}
