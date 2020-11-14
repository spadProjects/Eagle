namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Editedlogtable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Logs", "EntityId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Logs", "EntityId");
        }
    }
}
