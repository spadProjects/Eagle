namespace Eagle.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editedaarticle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ShortDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "ShortDescription");
        }
    }
}
