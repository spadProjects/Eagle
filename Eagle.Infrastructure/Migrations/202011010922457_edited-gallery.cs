namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedgallery : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Galleries", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Galleries", "Title", c => c.String());
        }
    }
}
