namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedPartners : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Partners", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Partners", "Title", c => c.String());
        }
    }
}
